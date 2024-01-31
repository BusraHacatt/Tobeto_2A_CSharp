 
namespace WebAPI
{
    internal class MapperConFiguration
    {
        private Action<object> value;

        public MapperConFiguration(Action<object> value)
        {
            this.value = value;
        }
    }
}