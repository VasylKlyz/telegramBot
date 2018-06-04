namespace Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int id { get; set; }

        public string UserName { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int ChatId { get; set; }

        public int? subscribe { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? StartToSub { get; set; }

        public string TaxId { get; set; }

        public DateTime? EndToSub { get; set; }

        public int? chanelNamesId { get; set; }

        public virtual channelNames channelNames { get; set; }
    }
}
