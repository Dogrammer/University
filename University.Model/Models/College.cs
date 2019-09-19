namespace University.Model.Models
{
    public class College : BaseModel
    {
        public string Name { get; set; }
        public int CollegeTypeId { get; set; }
        public CollegeType CollegeType { get; set; }
        

    }
}