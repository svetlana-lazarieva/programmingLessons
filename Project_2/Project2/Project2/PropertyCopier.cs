namespace Project2
{
    public class PropertyCopier<TParent, TChild> where TParent : class
                                                where TChild : class
    {
        public static void Copy(TParent from, TChild to)
        {
            var parentProperties = from.GetType().GetProperties();
            var childProperties = to.GetType().GetProperties();

            foreach (var parentProperty in parentProperties)
            {
                foreach (var childProperty in childProperties)
                {
                    if (parentProperty.Name == childProperty.Name && parentProperty.PropertyType == childProperty.PropertyType)
                    {
                        childProperty.SetValue(to, parentProperty.GetValue(from));
                        break;
                    }
                }
            }
        }
    }

}
