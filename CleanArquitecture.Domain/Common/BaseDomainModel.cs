
namespace CleanArquitecture.Domain.Common
{
    //Clase abstracta para evitar instancias o creacion de objetos  
    //directamente, solo se usa para hacer herencia
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatyBy { get; set; }
        public  DateTime LastModifiedDate { get; set; }
        public string? LastModifiedBy { get; set; }
    }
}