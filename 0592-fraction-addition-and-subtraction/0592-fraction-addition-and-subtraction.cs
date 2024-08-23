public class Solution {
    public string FractionAddition(string expression) {
        
        int numerator = 0, denominator = 1;
        int i = 0, n = expression.Length;

        while (i < n) {
            // Read the sign
            int sign = 1;
            if (expression[i] == '+' || expression[i] == '-') {
                sign = expression[i] == '-' ? -1 : 1;
                i++;
            }

            // Read the numerator
            int num = 0;
            while (i < n && Char.IsDigit(expression[i])) {
                num = num * 10 + (expression[i] - '0');
                i++;
            }

            // Skip the '/'
            i++;

            // Read the denominator
            int denom = 0;
            while (i < n && Char.IsDigit(expression[i])) {
                denom = denom * 10 + (expression[i] - '0');
                i++;
            }

            // Adjust the current fraction
            numerator = numerator * denom + sign * num * denominator;
            denominator *= denom;

            // Simplify after each operation
            int gcd = GCD(Math.Abs(numerator), denominator);
            numerator /= gcd;
            denominator /= gcd;
        }

        return $"{numerator}/{denominator}";
    }

    // Function to compute GCD of two numbers
    private int GCD(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

