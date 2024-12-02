using Domain.Attributes;

namespace Domain.Catalogs
{
    [Auditable]
    public class CatalogItemFeature
    {
         public int Id { get; set; }
        public required string Key { get; set; }
        public required string Value { get; set; }
        public required string Group {  get; set; }  
        public int CatalogItemId { get; set; }  
        public CatalogItem? CatalogItem { get; set; }    


    }

}

   

   
