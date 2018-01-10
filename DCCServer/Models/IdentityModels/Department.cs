using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DCCServer.Models.IdentityModels
{
    [Table("AspNetDepartments")]
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "部门名称")]
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(256)]
        public string C1 { get; set; }
        [StringLength(256)]
        public string C2 { get; set; }
        [StringLength(256)]
        public string C3 { get; set; }
        [StringLength(256)]
        public string C4 { get; set; }
        [StringLength(256)]
        public string C5 { get; set; }
        [StringLength(256)]
        public string C6 { get; set; }
        [StringLength(256)]
        public string C7 { get; set; }
        [StringLength(256)]
        public string C8 { get; set; }

    }
}
