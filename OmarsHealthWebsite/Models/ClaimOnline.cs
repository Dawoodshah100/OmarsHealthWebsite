using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OmarsHealthWebsite.Models
{
    public class ClaimOnline
    {

        [DisplayName("Are you making a claim for yourself or someone else?")]
        public virtual IdentityType Identity { get; set; }

        [DisplayName("Were you injured in the accident, either physically or psychologically")]
        public bool IsInjured { get; set; }

        [DisplayName("Where did the accident happen")]
        public InjuryTypes InjuryType { get; set; }

        [DisplayName("Did the Accident happen in England/Wales?")]
        public bool InEnglandOrWalesInjury { get; set; }

        [DisplayName("When did the accident happen?")]
        public DateTime DateOfTheIncident { get; set; }

        [DisplayName("Did you take legal advice?")]
        public bool LegalAdvice { get; set; }

        [DisplayName("Enter your details")]
        public CallMeBack CallMeBack { get; set; }

        [DisplayName("Which Part of your body were damaged?")]
        public InjuredBodyParts InjuryParts { get; set; }

        [DisplayName("Select the Parts of your body that were damaged?")]
        public InnerInjuredParts InjuryInnerParts { get; set; }

        [DisplayName("Are you able to work?")]
        public bool IsAbleToWork { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("When did the incident happen?")]
        public string TimeAffected { get; set; }

       



    }


    public enum IdentityType
    {
        [Display(Name = "For Me")]
        Me,
        [Display(Name = "For Someone Else")]
        Anyone
    }

    public enum InjuryTypes
    {
        [Display(Name = "On the Road")]
        OnTheRoad,
        [Display(Name = "At Work")]
        AtWork,
        [Display(Name = "In a Public Place")]
        InAPulicPlace,
        [Display(Name = "Medical Negligence")]
        MedicalNegligence,
        [Display(Name = "My home or somebody else's")]
        MyHomeOrSomebodyElses
    }
    public enum InjuredBodyParts
    {
       [Display(Name = "Whole body")]
        WholeBody,
        [Display(Name = "Legs")]
        Legs,
        [Display(Name = "Head")]
        Head,
        [Display(Name = "Other")]
        Other
        }
    public enum InnerInjuredParts
    {
        [Display(Name = "Skin")]
        Skin,
        [Display(Name = "Muscles")]
        Muscles,
        [Display(Name = "Spine")]
        Spine

    }
}