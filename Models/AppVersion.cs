namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AppVersion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AppId { get; set; }

        [Column("AppVersion")]
        [Required]
        public string AppVersion1 { get; set; }
    }
}
