using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Core.Models
{
    public class Devices : BaseEntity
    {
        [Column("Device Id")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "The batch id cannot be null")]
        public string BatchId { get; set; }

        [Required(ErrorMessage = "Serial number cannot be null")]
        public String SerialNumber { get; set; }

        [Required(ErrorMessage = "Manufacturer field is required")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Status cannot be null")]
        public Status Status { get; set; }

        public bool InGoodCondition { get; set; }
    }

    public enum Status
    {
        InStore,
        InTransit,
        WithMe,
        WithAgent
    }
}
