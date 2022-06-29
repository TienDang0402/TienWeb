//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanlaptop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            this.BINHLUAN = new HashSet<BINHLUAN>();
            this.HOADON = new HashSet<HOADON>();
        }
    
        public int MAKH { get; set; }

        [Display(Name ="TENKH")]
        [Required(ErrorMessage ="Kh�ng ???c b? tr?ng t�n")]
        public string TENKH { get; set; }

        [Display(Name = "DIACHI")]
        [Required(ErrorMessage = "Kh�ng ???c b? tr?ng t�n")]
        public string DIACHI { get; set; }

        [Display(Name = "USERNAME")]
        [Required(ErrorMessage = "Kh�ng ???c b? tr?ng t�n")]
        public string USERNAME { get; set; }

        [Display(Name = "PASSWORD")]
        [Required(ErrorMessage = "Kh�ng ???c b? tr?ng ")]
        public string PASSWORD { get; set; }

        [Display(Name = "SDT")]
        [Required(ErrorMessage = "Kh�ng ???c b? tr?ng ")]
        public string SDT { get; set; }

        [Display(Name = "CCCD")]
        [Required(ErrorMessage = "Kh�ng ???c b? tr?ng ")]
        public string CCCD { get; set; }

        [Display(Name = "EMAIL")]
        [Required(ErrorMessage = "Kh�ng ???c b? tr?ng ")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="??nh d?ng ch?a ?�ng nh?p l?i")]
        public string EMAIL { get; set; }
        public Nullable<System.DateTime> NGAYSINH { get; set; }
        public bool TRANGTHAI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BINHLUAN> BINHLUAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADON { get; set; }


        public string Name; // g�n  t�n t�i kho?n ho?c t�n ng??i d�ng ??ng nh?p

        //================ng�y/th�ng/n?m c?a ng??i d�ng==========================
        public int? Day;
        public int? Month;
        public int? Year;
    }
}