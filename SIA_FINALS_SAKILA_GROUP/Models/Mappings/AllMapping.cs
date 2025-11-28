using AutoMapper;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Actor;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Country;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Customer;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Address;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Category;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Film;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.FilmActor;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.City;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.FilmCategory;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.FilmText;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Inventory;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Language;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Rental;
using SIA_FINALS_SAKILA_GROUP.Models.DTOS.Staff;

namespace SIA_FINALS_SAKILA_GROUP.Models.Mappings
{
    public class AllMapping : Profile
    {
        public AllMapping()
        {
            // Country Mappings
            CreateMap<Country, CountryReadDTO>();
            CreateMap<CountryCreateDTO, Country>();
            CreateMap<CountryUpdateDTO, Country>();

            // Customer Mappings
            CreateMap<Customer, CustomerReadDTO>();
            CreateMap<CustomerCreateDTO, Customer>();
            CreateMap<CustomerUpdateDTO, Customer>();

            //Actor Mappings
            CreateMap<Actor, ActorReadDTO>();
            CreateMap<ActorUpdateDTO, Actor>();
            CreateMap<ActorCreateDTO, Actor>();

            //Address Mappings
            CreateMap<Address, AddressReadDTO>();
            CreateMap<AddressCreateDTO, Address>();
            CreateMap<AddressUpdateDTO, Address>();

            //Category Mappings
            CreateMap<Category, CategoryReadDTO>();
            CreateMap<CategoryCreateDTO, Category>();
            CreateMap<CategoryUpdateDTO, Category>();

            //Film Mappings
            CreateMap<Film, FilmReadDTO>();
            CreateMap<FilmCreateDTO, Film>();
            CreateMap<FilmUpdateDTO, Film>();

            //FilmActor Mappings
            CreateMap<FilmActor, FilmActorReadDTO>();
            CreateMap<FilmActorCreateDTO, FilmActor>();
            CreateMap<FilmActorUpdateDTO, FilmActor>();

            //City Mappings
            CreateMap<City, CityReadDTO>();
            CreateMap<CityCreateDTO, City>();
            CreateMap<CityUpdateDTO, City>();

            //Customer Mappings
            CreateMap<Customer, CustomerReadDTO>();
            CreateMap<CustomerCreateDTO, Customer>();
            CreateMap<CustomerUpdateDTO, Customer>();

            //FilmCategory Mappings
            CreateMap<FilmCategory, FilmCategoryReadDTO>();
            CreateMap<FilmCategoryCreateDTO, FilmCategory>();
            CreateMap<FilmCategoryUpdateDTO, FilmCategory>();

            //FilmText Mappings
            CreateMap<FilmText, FilmTextReadDTO>();
            CreateMap<FilmTextCreateDTO, FilmText>();
            CreateMap<FilmTextUpdateDTO, FilmText>();

            //Inventory Mappings
            CreateMap<Inventory, InventoryReadDTO>();
            CreateMap<InventoryCreateDTO, Inventory>();
            CreateMap<InventoryUpdateDTO, Inventory>();

            //Language Mappings
            CreateMap<Language, LanguageCreateDTO>();
            CreateMap<LanguageUpdateDTO, Language>();
            CreateMap<LanguageCreateDTO, Language>();

            //Payment Mappings
            CreateMap<Language, LanguageReadDTO>();
            CreateMap<LanguageUpdateDTO, Language>();
            CreateMap<LanguageCreateDTO, Language>();

            //Rental Mappings
            CreateMap<Rental, RentalReadDTO>();
            CreateMap<RentalCreateDTO, Rental>();
            CreateMap<RentalUpdateDTO, Rental>();

            //Staff Mappings
            CreateMap<Staff, StaffReadDTO>();
            CreateMap<StaffCreateDTO, Staff>();
            CreateMap<StaffUpdateDTO, Staff>();

            //Store Mappings
            CreateMap<Staff, StaffReadDTO>();
            CreateMap<StaffCreateDTO, Staff>();
            CreateMap<StaffUpdateDTO, Staff>();
        }
    }

}
