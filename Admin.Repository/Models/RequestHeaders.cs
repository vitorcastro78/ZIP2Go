using System.ComponentModel.DataAnnotations;

namespace Admin.Repository.Models
{
    public class RequestHeaders
    {
        public bool? _async { get; set; }

        public string acceptEncoding { get; set; }

        public string contentEncoding { get; set; }

        [Key]
        public Guid Id { get; set; }

        public string idempotencyKey { get; set; }

        public string Name { get; set; }

        public string zuoraEntityIds { get; set; }

        public string zuoraTrackId { get; set; }
    }
}