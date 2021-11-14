namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AddApp")]
    public partial class AddApp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AppId { get; set; }

        [Required]
        [StringLength(50)]
        public string AppName { get; set; }

        public string AppDescription { get; set; }

        [StringLength(50)]
        public string InsertedBy { get; set; }

        public DateTime? InsertedOn { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [Required]
        public string AppLink { get; set; }

        public string AppIcon { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DownloadCount { get; set; }

        public bool? Active { get; set; }
    }
}
