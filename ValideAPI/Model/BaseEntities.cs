namespace ValideAPI.Model
{
    public class BaseEntities
    {
        public BaseEntities()
        {
            CreatedAt = DateTime.UtcNow;
            UpdateAt = DateTime.UtcNow;
            IsDeleted = false;
        }
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsDeleted { get; set; }

        public void SetAsDeleted()
        {
            IsDeleted = true;
        }
    }


}
