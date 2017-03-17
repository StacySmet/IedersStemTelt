namespace TreeOption
{
    public class Voorwaarde
    {
        public string var { get; set; }
        public string val { get; set; }


        public Voorwaarde(string var, string val)
        {
            this.val = val;
            this.var = var;
        }

        public bool EqualVar(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Voorwaarde c = (Voorwaarde)obj;
            return var.ToLower().Equals(c.var.ToLower());
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Voorwaarde c = (Voorwaarde)obj;
            if(c.var.ToLower().Equals(var.ToLower()))
            {
                return c.val.ToLower().Equals(val.ToLower());
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}