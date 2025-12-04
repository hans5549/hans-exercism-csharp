namespace Examer.Extension
{
    public static class Badge
    {
        public static string Print(int? id, string name, string? department)
        {
            bool idIsNull = id == null;
            bool nameIsNull = string.IsNullOrEmpty(name);
            bool departmentIsNull = string.IsNullOrEmpty(department);

            if (!idIsNull && !nameIsNull && !departmentIsNull)
            {
                return $"[{id}] - {name} - {department!.ToUpper()}";
            }
            else if (idIsNull && !nameIsNull && !departmentIsNull)
            {
                return $"{name} - {department!.ToUpper()}";
            }
            else if (!idIsNull && !nameIsNull && departmentIsNull)
            {
                return $"[{id}] - {name} - OWNER";
            }
            else if (idIsNull && !nameIsNull && departmentIsNull)
            {
                return $"{name} - OWNER";
            }
            else
            {
                throw new NotImplementedException("Please implement the (static) Badge.Print() method");
            }
        }
    }
}
