namespace DataSource.Models
{
    public class CompositionDataModel
    {
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            CompositionDataModel m = obj as CompositionDataModel;
            if (m as CompositionDataModel == null)
                return false;

            return m.Id == this.Id && m.IngredientId == this.IngredientId && m.Quantity == this.Quantity;
        }
    }
}
