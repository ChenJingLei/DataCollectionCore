using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DCCServer.Models.IdentityModels
{
    [Table("AspNetWeChatAccounts")]
    public class WeChatAccount
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Display(Name = "微信标识")]
        public string OpenId { get; set; }
        [StringLength(256)]
        public string NickName { get; set; }
        [StringLength(256)]
        public string AvatarUrl { get; set; }
        [StringLength(256)]
        public string Gender { get; set; }
        [StringLength(256)]
        public string City { get; set; }
        [StringLength(256)]
        public string Province { get; set; }
        [StringLength(256)]
        public string Country { get; set; }
        [StringLength(256)]
        public string UnionId { get; set; }
        [StringLength(256)]
        public string Lauguage { get; set; }
    }

}
