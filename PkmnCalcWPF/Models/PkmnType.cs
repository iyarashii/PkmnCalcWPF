namespace PkmnCalcWPF.Models
{
    // all pokemon types in this app derive from this class
    public abstract class PkmnType : IPkmnType
    {
        public abstract string TypeName { get; }
        public double DmgMultiplier { get; set; }
        public abstract string TypeColor { get; }

        // calculates dmg multiplier by executing CalculateDmgMultiplierForASingleType on selected types
        public double CalculateDmgMultiplier(IPkmnType defendingPkmnPrimaryType, IPkmnType defendingPkmnSecondaryType)
        {
            double primaryTypeMultiplier = CalculateDmgMultiplierForASingleType(defendingPkmnPrimaryType);
            double secondaryTypeMultiplier = CalculateDmgMultiplierForASingleType(defendingPkmnSecondaryType);

            // check if both types are the same type
            if (defendingPkmnPrimaryType == defendingPkmnSecondaryType)
            {
                return primaryTypeMultiplier;
            }
            else
            {
                return primaryTypeMultiplier * secondaryTypeMultiplier;
            }
        }
        // abstract method that is defined differently by every pokemon type
        public abstract double CalculateDmgMultiplierForASingleType(IPkmnType pkmnType);
    }
}
