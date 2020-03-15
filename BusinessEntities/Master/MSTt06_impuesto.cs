namespace BusinessEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSTt06_impuesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSTt06_impuesto()
        {
            PROt09_producto = new HashSet<PROt09_producto>();
            TNSt01_comp_recibido = new HashSet<TNSt01_comp_recibido>();
        }

        [Key]
        public int id_impuesto { get; set; }

        [StringLength(10)]
        public string cod_impuesto { get; set; }

        [StringLength(150)]
        public string txt_desc { get; set; }

        [StringLength(30)]
        public string txt_abrv { get; set; }

        public decimal por_impto { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt09_producto> PROt09_producto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt01_comp_recibido> TNSt01_comp_recibido { get; set; }
    }
}
