namespace DemoHideShowBlazorChildComponents.Models
{
    public interface IItemService
    {
        List<Item> GetItems();
        Item GetItem(int id);
        void UpdateItem(Item model);
        void AddItem(Item i);
    }

    public class ItemService : IItemService
    {
        private List<Item> Items = new();

        public List<Item> GetItems() => Items;
        public Item GetItem(int id) => Items.FirstOrDefault(_ => _.Id == id);

        public void UpdateItem(Item model)
        {
            Item i = Items.FirstOrDefault(_ => _.Id == model.Id);
            i.Name = model.Name; i.Quantity = model.Quantity;
        }

        public void AddItem(Item i)
        {
            Items.Add(i);
        }

        public void DeleteItem(int id)
        {
            Items.Remove(Items.FirstOrDefault(_ => _.Id == id));
        }
    }

}
