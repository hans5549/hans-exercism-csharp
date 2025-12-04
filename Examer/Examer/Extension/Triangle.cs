namespace Examer.Extension
{
    public static class Triangle
    {
        // 不等邊三角形
        public static bool IsScalene(double side1, double side2, double side3)
        {
            bool isValid = IsValidTriangle(side1, side2, side3);
            if (!isValid)
            {
                return false;
            }
            return (side1 != side2) && (side2 != side3) && (side1 != side3);
        }

        // 等腰三角形
        public static bool IsIsosceles(double side1, double side2, double side3)
        {
            bool isValid = IsValidTriangle(side1, side2, side3);
            if (!isValid)
            {
                return false;
            }
            return (side1 == side2) || (side1 == side3) || (side2 == side3);
        }

        // 等邊三角形
        public static bool IsEquilateral(double side1, double side2, double side3)
        {
            bool isValid = IsValidTriangle(side1, side2, side3);
            if (!isValid)
            {
                return false;
            }
            return (side1 == side2) && (side2 == side3) && (side1 == side3);
        }

        private static bool IsValidTriangle(double side1, double side2, double side3)
        {
            // 檢查所有邊長是否為正數且為有效數值
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                return false;
            }

            // 檢查是否為有效數值（排除 NaN 和 Infinity）
            if (double.IsNaN(side1) || double.IsNaN(side2) || double.IsNaN(side3) ||
                double.IsInfinity(side1) || double.IsInfinity(side2) || double.IsInfinity(side3))
            {
                return false;
            }

            return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
        }
    }
}
