﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WebApi.Entity;

namespace WebApi.Data
{
    public class ContextSQL<TEntity> :  IRepository<TEntity> where TEntity : class, new () // tiene que ser una clase y tener un constructor
    {

        public ContextSQL(string ConnectionString)
        {
            _SettingConexion = ConnectionString;
        }

        #region Declaration

        private string _SettingConexion;

        #endregion

        #region Properties

        public string EntityName
        {
            get
            {
                Type type = typeof(TEntity);
                return type.Name;
            }
        }

        public string MessageError
        {
            get; private set;
        }

        #endregion

        #region Catch Sql Errors

        void cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageError = e.Message;
        }

        #endregion

        #region Interface Method

        public List<TEntity> List()
        {
            DataTable dt;
            try
            {
                dt = Fill("List").Tables[0];
            }
            catch (Exception)
            {
                throw;
            }
            return EntityBase.ToList<TEntity>(dt);
        }

        public TEntity Get(int Id)
        {
            Dictionary<string, string> lDictionary = new Dictionary<string, string>();
            List<dynamic> lDynamic = new List<dynamic>();
            DataSet ds = new DataSet();
            lDictionary.Add("Id", Id.ToString());
            try
            {
                ds = Fill("Get", lDictionary);
            }
            catch (Exception)
            {
                throw;
            }
            return EntityBase.ToList<TEntity>(ds.Tables[0]).SingleOrDefault();
        }

        public List<dynamic> Find(Dictionary<string, string> lParam)
        {
            List<dynamic> lDynamic = new List<dynamic>();
            DataSet ds = new DataSet();
            try
            {
                ds = Fill("Find", lParam);
                if (ds.Tables.Count > 0)
                {
                    lDynamic = EntityBase.ToDynamic(ds.Tables[0]);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return lDynamic;
        }

        public void Delete(int Id)
        {
            Dictionary<string, string> lDictionary = new Dictionary<string, string>();
            lDictionary.Add("Id", Id.ToString());
            try
            {
                ExecuteNonQuery("Delete", lDictionary);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Insert(Dictionary<string, string> lParam)
        {
            try
            {
                ExecuteNonQuery("Insert", lParam);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Dictionary<string, string> lParam)
        {
            try
            {
                ExecuteNonQuery("Update", lParam);
            }
            catch (Exception)
            {
                throw;
            }
        }


        #endregion

        #region Store Procedures Common Function

        public DataSet Fill(string FunctionName, Dictionary<string, string> Parameters = null)
        {
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da;
            StringBuilder sbKey = new StringBuilder();
            List<dynamic> lDynamic = new List<dynamic>();
            StringBuilder sb = new StringBuilder();
            sb.Append(EntityName);
            sb.Append("_");
            sb.Append(FunctionName);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sb.ToString();
            try
            {

                Parameters = Parameters == null ? new Dictionary<string, string>() : Parameters;

                foreach (var d in Parameters)
                {
                    sbKey.Clear();
                    sbKey.Append("@");
                    sbKey.Append(d.Key);
                    cmd.Parameters.Add(new SqlParameter(sbKey.ToString(), d.Value));
                }

                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = _SettingConexion;
                    cmd.Connection = cn;
                    MessageError = string.Empty;
                    da = new SqlDataAdapter(cmd);
                    cn.InfoMessage += cn_InfoMessage;
                    cn.Open();
                    da.Fill(ds);
                    cn.Close();
                }

                if (MessageError.Length > 0 && MessageError.StartsWith("Warning") == false && MessageError.StartsWith("Advertency") == false)
                {
                    ds = new DataSet();
                    ds.Tables.Add(new DataTable());
                    throw new Exception(MessageError);
                }

            }
            catch (SqlException)
            {
                if (MessageError.Length > 0 && MessageError.StartsWith("Warning") == false && MessageError.StartsWith("Advertency") == false)
                    throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cmd.Dispose();
            }
            return ds;
        }


        public void ExecuteNonQuery(string FunctionName, Dictionary<string, string> Parameters = null)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(EntityName);
            sb.Append("_");
            sb.Append(FunctionName);
            SqlCommand cmd = new SqlCommand();
            MessageError = string.Empty;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sb.ToString();
            StringBuilder sbKey = new StringBuilder();
            cmd.CommandTimeout = 60;
            try
            {
                Parameters = Parameters == null ? new Dictionary<string, string>() : Parameters;

                foreach (var d in Parameters)
                {
                    sbKey.Clear();
                    sbKey.Append("@");
                    sbKey.Append(d.Key);
                    cmd.Parameters.Add(new SqlParameter(sbKey.ToString(), d.Value));
                }

                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = _SettingConexion;
                    cn.InfoMessage += cn_InfoMessage;
                    cmd.Connection = cn;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }

                if (MessageError.Length > 0 && MessageError.StartsWith("Warning") == false && MessageError.StartsWith("Advertency") == false) 
                {
                    throw new Exception(MessageError);  
                }
            }
            catch (SqlException ex)
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
