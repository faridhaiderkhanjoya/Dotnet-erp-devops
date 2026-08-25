using System.ComponentModel.DataAnnotations;

namespace MTDBMVC.Models
{
    public class MtPurMst
    {
        [Key]
        [StringLength(20)]
        public string InvCd { get; set; } = string.Empty;

        [Required(ErrorMessage = "Invoice date select karen")]
        [DataType(DataType.Date)]
        public DateTime? InvDt { get; set; }

        [Required(ErrorMessage = "Supplier select karen")]
        [StringLength(4)]
        public string TrdCd { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime? RcvdDt { get; set; }

        public MtTraderMst? Trader { get; set; }
        public List<MtPurDtl>? Details { get; set; }
    }
}
