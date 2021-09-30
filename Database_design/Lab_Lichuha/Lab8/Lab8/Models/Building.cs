namespace Lab8.Models
{
    public class Building
    {
        public virtual int ID { get; set; }
        public virtual string TypeName { get { return Type.Name; } }
        public virtual TypeBuilding Type { get; set; }
        public virtual double Size { get; set; }
        public virtual double Price { get; set; }
    }
}
