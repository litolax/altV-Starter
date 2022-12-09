namespace altVStarter
{
    internal class Field
    {
        public Field(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}