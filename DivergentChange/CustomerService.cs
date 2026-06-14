namespace DivergentChange;

using System;
using System.Text.RegularExpressions;

public class CustomerService
{
    public bool IsValidEmail(string email)
    {
        if (email == null)
        {
            return false;
        }

        return Regex.IsMatch(
            email,
            @"^[A-Za-z0-9+_.-]+@[A-Za-z0-9.-]+$");
    }

    public string FormatDisplayName(string firstName, string lastName)
    {
        return firstName.Trim() + " " + lastName.Trim().ToUpper();
    }

    public int CalculateLoyaltyPoints(int numberOfPurchases)
    {
        return numberOfPurchases * 10;
    }

    public string DetermineAccountStatus(int daysSinceLastLogin)
    {
        if (daysSinceLastLogin > 365)
        {
            return "INACTIVE";
        }
        else if (daysSinceLastLogin > 30)
        {
            return "DORMANT";
        }

        return "ACTIVE";
    }
}