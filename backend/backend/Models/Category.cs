using System.ComponentModel.DataAnnotations;

namespace backend.Models
{
    public enum Category
    {
        [Display(Name = "Reparos Domésticos")]
        DomesticRepair,
        [Display(Name = "Jardinagem")]
        Gardening,
        [Display(Name = "Transporte Particular")]
        PrivateTransportation,
        [Display(Name = "Massagem")]
        Massage
    }
}