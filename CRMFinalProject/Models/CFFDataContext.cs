using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using CooperativeFuneralFundInc.Models.DropDownMenu;
using CooperativeFuneralFundInc.Models.TasksManagement;
using CooperativeFuneralFundInc.Models.UserManagement;
using CooperativeFuneralFundInc.Models.ClientManagement;


using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CooperativeFuneralFundInc.Models.SupplyRequest
{
    public class CFFDataContext:IdentityDbContext<User>
    {

        public CFFDataContext(DbContextOptions<CFFDataContext> options) : base(options) { }
        public DbSet<SupplyRequest> SupplyRequests { get; set; }
        public DbSet<ClientSupplier> ClientSuppliers { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Owner> OwnerNames { get; set; }
        public DbSet<RequestType> RequestTypes { get; set; }
        public DbSet<RequestOrigin> RequestOrigins { get; set; }

        public DbSet<TaskManagement> TaskManagements { get; set; }

        public DbSet<PhoneNumberType> NumberTypes { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<RelatedTo> RelatedTos { get; set; }

        public DbSet<Client> Clients { get; set; }


        public DbSet<Status> Statuses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Client>().HasData(
                new Client { ClientID=1,Documents="",Branding="",ClientContacts=""}
                );
          /*  modelBuilder.Entity<TaskManagement>().HasData(
                new TaskManagement
                {
                    TaskManagementId=1,
                    Status N = "New",
                    Owner=1,
                    RelatedTo="Test",
                    RelatedToName="Test",
                    RequestType=1,
                    Priority=1,
                    CreateBy="Test",
                    UpdatedBy="Test"
                }
                );*/

          /*  modelBuilder.Entity<SupplyRequest>().HasData
         (
               new SupplyRequest
               {
                   SupplyRequestId=1,
                   Status = 1,
                   StatusComments = "test",
                   OrderItemsID = 1,
                   RequestOriginId = 1,
                   RequestType = 1,
                   ClientSupplierID = 1,
                   Owner = 1,
                   CreatedBy = "Test",
                   CreateTime = DateTime.Now,
                   UpdatedBy = "Test"
               }
               );*/


        modelBuilder.Entity<Status>().HasData(

               new Status
               {
                   StatusId = "New",
                   StatusDescription = "New"
               },
               new Status
               {
                   StatusId = "In-Process",
                   StatusDescription = "In-Process"
               },
               new Status
               {
                   StatusId = "Completed",
                   StatusDescription = "Completed"
               },
               new Status
               {
                   StatusId = "On hold",
                   StatusDescription = "On hold"
               },
               new Status
               {
                   StatusId = "Cancelled",
                   StatusDescription = "Cancelled"
               }
         );

            modelBuilder.Entity<OrderItems>().HasData
                (
                    new OrderItems
                    {
                        OrderItemsID = "Preneed agreement",
                        OrderItemsName = "Preneed agreement"
                    },
                    new OrderItems
                       {
                        OrderItemsID = "Account update/Claim form",
                        OrderItemsName = "Account update/Claim form"
                    },
                    new OrderItems
                    {
                        OrderItemsID = "Itemizations form",
                        OrderItemsName = "Itemizations form"
                    },
                    new OrderItems
                    {
                        OrderItemsID = "Return envelopes.",
                        OrderItemsName = "Return envelopes."
                    },
                    new OrderItems
                    {
                        OrderItemsID = "Postage paid envelopes.",
                        OrderItemsName = "Postage paid envelopes."
                    },
                    new OrderItems
                    {
                        OrderItemsID = "Deposit tickets",
                        OrderItemsName = "Deposit tickets"
                    },
                    new OrderItems
                    {
                        OrderItemsID = "Planning guides",
                        OrderItemsName = "Planning guides"
                    },
                    new OrderItems
                    {
                        OrderItemsID = "Funding your funeral in advance brochure",
                        OrderItemsName = "Funding your funeral in advance brochure"
                    },
                    new OrderItems
                    {
                        OrderItemsID = "Monthly monitors",
                        OrderItemsName = "Monthly monitors"
                    },
                    new OrderItems
                    {
                        OrderItemsID = "Service and merchandise forms",
                        OrderItemsName = "Service and merchandise forms"
                    },
                    new OrderItems
                    {
                        OrderItemsID = "Investment election form",
                        OrderItemsName = "Investment election form"
                    },
                    new OrderItems
                    {
                        OrderItemsID = "Other",
                        OrderItemsName = "Other"
                    }
                );
            modelBuilder.Entity<RequestOrigin>().HasData(

                    new RequestOrigin
                    {
                        RequestOriginId = "Phone",
                        RequestOriginDescription = "Phone"
                    },
                    new RequestOrigin
                    {
                        RequestOriginId = "Fax",
                        RequestOriginDescription = "Fax"
                    },
                    new RequestOrigin
                    {
                        RequestOriginId = "Email",
                        RequestOriginDescription = "Email"
                    },
                    new RequestOrigin
                    {
                        RequestOriginId = "Mail",
                        RequestOriginDescription = "Mail"
                    },
                    new RequestOrigin
                    {
                        RequestOriginId = "Regional Manager",
                        RequestOriginDescription = "Regional manager"
                    },
                    new RequestOrigin
                    {
                        RequestOriginId = "Other",
                        RequestOriginDescription = "Other"
                    }
                );
            modelBuilder.Entity<RequestType>().HasData(
                new RequestType { RequestTypeId = "Vendor", RequestTypeDescription = "Vendor" },
                new RequestType { RequestTypeId = "Client", RequestTypeDescription = "Client" }
                );

            modelBuilder.Entity<ClientSupplier>().HasData(
                new ClientSupplier { ClientSupplierID = 1, ClientSupplierName = "Client 1" },
                new ClientSupplier { ClientSupplierID = 2, ClientSupplierName = "Client 2" }
                );

            modelBuilder.Entity<Priority>().HasData(
                     new Priority { PriorityId = "High", PriorityName = "High" },
                     new Priority { PriorityId = "Medium", PriorityName = "Medium" },
                     new Priority { PriorityId = "Low", PriorityName = "Low" }

                     );

            modelBuilder.Entity<RelatedTo>().HasData(
          new RelatedTo { RelatedToId = "Customer", RelatedToName = "Customer" },
          new RelatedTo { RelatedToId = "Potential customer", RelatedToName = "Potential customer" },
          new RelatedTo { RelatedToId = "Lead", RelatedToName = "Lead" },
          new RelatedTo { RelatedToId = "In-house", RelatedToName = "In-house" },
          new RelatedTo { RelatedToId = "Other", RelatedToName = "Other" }
          );



            /*  modelBuilder.Entity<NotesSection>().HasData(
                  new NotesSection {NotesSectionId=1, RequestOriginId = 1, Note = "Test note", CreatedBy = "Developer" }
                  );
            */

            modelBuilder.Entity<PhoneNumberType>().HasData(
                new PhoneNumberType { Id = "Home", Name = "Home" },
                new PhoneNumberType { Id = "Mobile", Name = "Mobile" },
                new PhoneNumberType { Id = "Work", Name = "work" },
                new PhoneNumberType { Id = "Other", Name = "Other" }

  );

        }





        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            UserManager<User> userManager =
                serviceProvider.GetRequiredService<UserManager<User>>();
            RoleManager<IdentityRole> roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            string username = "Admin";
            string password = "Sesame";
            string roleName = "Admin";
            string roleName2 = "User";
            string roleName3 = "Visitor";
            string fName = "Admin";
            string lName = "Admin";
            string numberType = "Other";

            // if role doesn't exist, create it
            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            // if username doesn't exist, create it and add to role
            if (await userManager.FindByNameAsync(username) == null)
            {
                User user = new User { UserName = username, firstName = fName, lastName = lName, numberType = numberType };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }

    }
}