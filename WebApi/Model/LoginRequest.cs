using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApi.Model
{
    public class LoginRequest
    {
        /// <summary>
        /// Username
        /// </summary>
        /// <example>admin</example>
        [Required]
        [JsonPropertyName("username")]
        public string UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        /// <example>0000</example>
        [Required]
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
