namespace ConsoleUI
{
    internal abstract class Entity 
    {
        internal int Id { get; set; }
        internal DateTime CreatedAt { get; } //Read-Only Property
      
        internal DateTime? UpdatedAt { get; set; } //null olabilir

      
        public Entity()
        {
            Id = generateId(); 
            CreatedAt = DateTime.UtcNow; 

            Console.WriteLine("Bir Entity() oluştu");

        }

        public Entity(int id)//:this() 
        {
            Id = id;
            Console.WriteLine("Bir Entity (id)oluştu");
        }
      
        protected virtual int generateId()
        {
            return ++EntityIdHelper.LastId;
        } 


    }
}

internal static class EntityIdHelper
{
    public static int LastId { get; set; } = 0;
}
