namespace fiasxml
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OperationStatus
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long OPERSTATID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string NAME { get; set; }
    }
}