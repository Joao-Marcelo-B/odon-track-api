using Odon.Track.Application.Data.MySQL.Entity;

namespace Odon.Track.Application.Data.UpdateEntities
{
    public static class UpdateExtensions
    {
        public static void UpdateValueProntuario(this Prontuario target, Prontuario source)
        {
            var properties = typeof(Prontuario).GetProperties();
            foreach (var property in properties)
            {
                var value = property.GetValue(source);

                if (value is Paciente || value is Professor || value is Estudante)
                    continue;

                if (value is DateTime && ((DateTime)value).ToString() == DateTime.MinValue.ToString())
                    continue;

                if (value != null)
                {
                    property.SetValue(target, value);
                }
            }
        }

        public static void UpdateValueEndodontia(this EndodontiaEntity target, EndodontiaEntity source)
        {
            var properties = typeof(EndodontiaEntity).GetProperties();
            foreach (var property in properties)
            {
                var value = property.GetValue(source);

                if (value is DateTime && ((DateTime)value).ToString() == DateTime.MinValue.ToString())
                    continue;

                if (value != null)
                {
                    property.SetValue(target, value);
                }
            }
        }

        public static void InsertValueEntity<T>(this T target, T source)
        {
            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                var value = property.GetValue(source);
                if (value != null)
                {
                    property.SetValue(target, value);
                }
            }
        }
    }
}
