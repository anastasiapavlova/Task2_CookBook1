namespace DataSource.Models
{
    public class IngredientDataModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            IngredientDataModel m = obj as IngredientDataModel;
            if (m as IngredientDataModel == null)
                return false;

            return m.Id == this.Id && m.Name == this.Name;
        }
    }
}
