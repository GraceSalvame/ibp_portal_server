using Humanizer;
using ibp_portal_server.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Claims;

namespace ibp_portal_server.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }
        
        public DbSet<Account_status> Account_statuses { get; set; }
        public DbSet<Activity_log> Activity_logs { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Card_replenishment> Card_replenishments { get; set; }
        public DbSet<Corporate_affiliate> Corporate_affiliates { get; set; }
        public DbSet<Emergency_contact> Emergency_contacts { get; set; }
        public DbSet<Employment_sector> Employment_sectors { get; set; }
        public DbSet<Government_id> Government_ids { get; set; }
        public DbSet<Ibp> Ibps { get; set; }
        public DbSet<Ibp_information_update> Ibp_information_updates { get; set; }
        public DbSet<Ibp_registration> Ibp_registrations { get; set; }
        public DbSet<Ibp_type> Ibp_types { get; set; }
        public DbSet<Lost_cash_card_deactivation> Lost_cash_card_deactivations { get; set; }
        public DbSet<Lost_cash_card_fund_transfer> Lost_cash_card_fund_transfers { get; set; }
        public DbSet<Lost_cash_card_replacement> Lost_cash_card_replacements { get; set; }
        public DbSet<Mailer_pin> Mailer_pins { get; set; }
        public DbSet<Nature_of_request> Nature_of_requests { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Payment_channel> Payment_channels { get; set; }
        public DbSet<Payment_detail> Payment_details { get; set; }
        public DbSet<Payment_method> Payment_methods { get; set; }
        public DbSet<Payment_transaction> Payment_transactions { get; set; }
        public DbSet<Payout_related_concern> Payout_related_concerns { get; set; }
        public DbSet<Payout_related_concern_specification> Payout_related_concern_specifications { get; set; }
        public DbSet<Payout_related_concern_sub_specification> Payout_related_concern_sub_pecifications { get; set; }
        public DbSet<Payout_type> Payout_types { get; set; }
        public DbSet<Recruitment_channel> Recruitment_channels { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Request_specification> Request_specifications { get; set; }
        public DbSet<Request_sub_specification> request_sub_specifications { get; set; }
        public DbSet<Request_transaction> Request_transactions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<User_log> User_logs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        //Registration
            // Account_status - Status (One-to-Many)
            modelBuilder.Entity<Account_status>()
                .HasOne(a => a.Status)
                .WithMany(s => s.Account_statuses)
                .HasForeignKey(a => a.status_id)
                .IsRequired();

            // Corporate_affiliate - Ibp (One-to-Many)
            modelBuilder.Entity<Corporate_affiliate>()
                .HasOne(a => a.Ibp)
                .WithMany(i => i.Corporate_affiliates)
                .HasForeignKey(a => a.ibp_id)
                .IsRequired();

            // Emergency_contact - Ibp (One-to-One)
            modelBuilder.Entity<Emergency_contact>()
                .HasOne(a => a.Ibp)
                .WithOne()
                .HasForeignKey<Emergency_contact>(a => a.ibp_id)
                .IsRequired();

            // Ibp - Ibp_type (One-to-Many)
            modelBuilder.Entity<Ibp>()
                .HasOne(a => a.Ibp_type)
                .WithMany(it => it.Ibps)
                .HasForeignKey(a => a.ibp_type_id)
                .IsRequired(false);

            // Ibp - Branch (One-to-Many)
            modelBuilder.Entity<Ibp>()
                .HasOne(a => a.Branch)
                .WithMany(b => b.Ibps)
                .HasForeignKey(a => a.branch_id)
                .IsRequired();

            // Ibp - Government_id (One-to-Many)
            modelBuilder.Entity<Ibp>()
                .HasOne(a => a.Government_id)
                .WithMany(g => g.Ibps)
                .HasForeignKey(a => a.government_id)
                .IsRequired();

            // Ibp - Recruitment_channel (One-to-Many)
            modelBuilder.Entity<Ibp>()
                .HasOne(a => a.Recruitment_channel)
                .WithMany(rc => rc.Ibps)
                .HasForeignKey(a => a.recruitment_channel_id)
                .IsRequired(false);

            // Ibp - Employment_sector (One-to-Many)
            modelBuilder.Entity<Ibp>()
                .HasOne(a => a.Employment_sector)
                .WithMany(es => es.Ibps)
                .HasForeignKey(a => a.employment_sector_id)
                .IsRequired();

            // Ibp - Status (One-to-Many)
            modelBuilder.Entity<Ibp>()
                .HasOne(a => a.Status)
                .WithMany(s => s.Ibps)
                .HasForeignKey(a => a.status_id)
                .IsRequired();

            // Ibp_registration - Ibp (One-to-Many)
            modelBuilder.Entity<Ibp_registration>()
                .HasOne(a => a.Ibp)
                .WithMany(i => i.Ibp_registrations)
                .HasForeignKey(a => a.ibp_id)
                .IsRequired();

            // Ibp_registration - User (One-to-Many)
            modelBuilder.Entity<Ibp_registration>()
                .HasOne(a => a.User)
                .WithMany(u => u.Ibp_registrations)
                .HasForeignKey(a => a.user_id)
                .IsRequired(false);

            // Ibp_registration - Role (One-to-Many)
            modelBuilder.Entity<Ibp_registration>()
                .HasOne(a => a.Role)
                .WithMany(r => r.Ibp_registrations)
                .HasForeignKey(a => a.role_id)
                .IsRequired();

            // Payment_method - Ibp (One-to-Many)
            modelBuilder.Entity<Payment_method>()
                .HasOne(a => a.Ibp)
                .WithMany(i => i.Payment_methods)
                .HasForeignKey(a => a.ibp_id)
                .IsRequired();

            // Payment_method - Payment_channel (One-to-Many)
            modelBuilder.Entity<Payment_method>()
                .HasOne(a => a.Payment_channel)
                .WithMany(pc => pc.Payment_Methods)
                .HasForeignKey(a => a.payment_channel_id)
                .IsRequired();

            // Payment_method - Status (One-to-Many)
            modelBuilder.Entity<Payment_method>()
                .HasOne(a => a.Status)
                .WithMany(bc => bc.Payment_methods)
                .HasForeignKey(a => a.status_id)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // User - Role (One-to-Many)
            modelBuilder.Entity<User>()
                .HasOne(a => a.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(a => a.role_id)
                .IsRequired();

            // User - Branch (One-to-Many)
            modelBuilder.Entity<User>()
                .HasOne(a => a.Branch)
                .WithMany(b => b.Users)
                .HasForeignKey(a => a.branch_id)
                .IsRequired(false);

            // User - Status (One-to-Many)
            modelBuilder.Entity<User>()
                .HasOne(a => a.Status)
                .WithMany(s => s.Users)
                .HasForeignKey(a => a.status_id)
                .IsRequired();

        //Adjustment Request
            // Card_replenishments - Request (One-to-Many)
            modelBuilder.Entity<Card_replenishment>()
               .HasOne(b => b.Request)
               .WithMany(c => c.Card_replenishments)
               .HasForeignKey(b => b.request_id)
               .IsRequired();

            //Ibp_information_update - Request (One-to-Many)
            modelBuilder.Entity<Ibp_information_update>()
               .HasOne(eb => eb.Request)
               .WithMany(cw => cw.Ibp_information_updates)
               .HasForeignKey(eb => eb.request_id)
               .IsRequired();

            // Ibp_information_update - Ibp_type (One-to-Many)
            modelBuilder.Entity<Ibp_information_update>()
                .HasOne(z => z.Ibp_type)
                .WithMany(it => it.Ibp_information_updates)
                .HasForeignKey(z => z.prev_ibp_type_id)
                .IsRequired(false);

            // Ibp_information_update - Branch (One-to-Many)
            modelBuilder.Entity<Ibp_information_update>()
                .HasOne(l => l.Branch)
                .WithMany(b => b.Ibp_information_updates)
                .HasForeignKey(l => l.prev_branch_id)
                .IsRequired(false);

            // Ibp_information_update - Government_id (One-to-Many)
            modelBuilder.Entity<Ibp_information_update>()
                .HasOne(a => a.Government_id)
                .WithMany(g => g.Ibp_information_updates)
                .HasForeignKey(a => a.prev_government_id)
                .IsRequired(false);

            // Ibp_information_update - Recruitment_channel (One-to-Many)
            modelBuilder.Entity<Ibp_information_update>()
                .HasOne(a => a.Recruitment_channel)
                .WithMany(rc => rc.Ibp_information_updates)
                .HasForeignKey(a => a.prev_recruitment_channel_id)
                .IsRequired(false);

            // Ibp_information_update - Employment_sector (One-to-Many)
            modelBuilder.Entity<Ibp_information_update>()
                .HasOne(a => a.Employment_sector)
                .WithMany(es => es.Ibp_information_updates)
                .HasForeignKey(a => a.prev_employment_sector_id)
                .IsRequired(false);

            // Lost_cash_card_deactivation - Request (One-to-Many)
            modelBuilder.Entity<Lost_cash_card_deactivation>()
                .HasOne(lccd => lccd.Request)
                .WithMany(r => r.Lost_cash_card_deactivations)
                .HasForeignKey(lccd => lccd.request_id)
                .IsRequired();

            // Lost_cash_card_fund_transfer - Request (One-to-Many)
            modelBuilder.Entity<Lost_cash_card_fund_transfer>()
                .HasOne(lccft => lccft.Request)
                .WithMany(r => r.Lost_cash_card_fund_transfers)
                .HasForeignKey(lccft => lccft.request_id)
                .IsRequired();

            // Lost_cash_card_replacement - Request (One-to-Many)
            modelBuilder.Entity<Lost_cash_card_replacement>()
                .HasOne(lccr => lccr.Request)
                .WithMany(r => r.Lost_cash_card_replacements)
                .HasForeignKey(lccr => lccr.request_id)
                .IsRequired();

            // Mailer_pin - Request (One-to-Many)
            modelBuilder.Entity<Mailer_pin>()
                .HasOne(mp => mp.Request)
                .WithMany(r => r.Mailer_pins)
                .HasForeignKey(mp => mp.request_id)
                .IsRequired();

            // Payout_related_concern - Request (One - to - Many)
            modelBuilder.Entity<Payout_related_concern>()
                .HasOne(prc => prc.Request)
                .WithMany(r => r.Payout_related_concerns)
                .HasForeignKey(prc => prc.request_id)
                .IsRequired();

            // Payout_related_concern_specification - Payout_related_concern (One - to - Many)
            modelBuilder.Entity<Payout_related_concern_specification>()
                .HasOne(prcs => prcs.Payout_related_concern)
                .WithMany(prc => prc.Payout_related_concern_specifications)
                .HasForeignKey(prcs => prcs.payout_related_concern_id)
                .IsRequired();

            // Payout_related_concern_sub_specification - Payout_related_concern_specification (One - to - Many)
            modelBuilder.Entity<Payout_related_concern_sub_specification>()
                .HasOne(prcss => prcss.Payout_related_concern_specification)
                .WithMany(prcs => prcs.Payout_related_concern_sub_specifications)
                .HasForeignKey(prcss => prcss.payout_related_concern_specification_id)
                .IsRequired();

            // Request - Ibp (One - to - Many)
            modelBuilder.Entity<Request>()
                .HasOne(r => r.Ibp)
                .WithMany(rds => rds.Requests)
                .HasForeignKey(r => r.ibp_id)
                .IsRequired(false);

            // Request - Branch (One - to - Many)
            modelBuilder.Entity<Request>()
                .HasOne(r => r.Branch)
                .WithMany(ras => ras.Requests)
                .HasForeignKey(r => r.branch_id)
                .IsRequired();

            // Request - Status (One - to - Many)
            modelBuilder.Entity<Request>()
                .HasOne(r => r.Status)
                .WithMany(rcs => rcs.Requests)
                .HasForeignKey(r => r.status_id)
                .IsRequired();

            // Request - Nature_of_request (One - to - Many)
            modelBuilder.Entity<Request>()
                .HasOne(r => r.Nature_of_request)
                .WithMany(rhs => rhs.Requests)
                .HasForeignKey(r => r.nature_of_request_id)
                .IsRequired();

            // Request - Request_specification (One - to - Many)
            modelBuilder.Entity<Request>()
                .HasOne(r => r.Request_specification)
                .WithMany(rqs => rqs.Requests)
                .HasForeignKey(r => r.request_specification_id)
                .IsRequired(false);

            // Request - Request_sub_specification (One - to - Many)
            modelBuilder.Entity<Request>()
                .HasOne(r => r.Request_sub_specification)
                .WithMany(rss => rss.Requests)
                .HasForeignKey(r => r.request_sub_specification_id)
                .IsRequired(false);

            // Request_specification - Nature_of_request (One - to - Many)
            modelBuilder.Entity<Request_specification>()
               .HasOne(rs => rs.Nature_of_request)
               .WithMany(a => a.Request_specifications)
               .HasForeignKey(rs => rs.nature_of_request_id)
               .IsRequired();

            // Request_sub_specification - Request_specification (One - to - Many)
            modelBuilder.Entity<Request_sub_specification>()
                .HasOne(rss => rss.Request_specification)
                .WithMany(rs => rs.request_sub_specifications)
                .HasForeignKey(rss => rss.request_specification_id)
                .IsRequired();

        //Payment
            // Payment - Payout_type (One - to - Many)
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Payout_type)
                .WithMany(pt => pt.Payments)
                .HasForeignKey(p => p.payment_type_id)
                .IsRequired();

            // Payment_detail - Ibp (One - to - Many)
            modelBuilder.Entity<Payment_detail>()
                .HasOne(pd => pd.Ibp)
                .WithMany(pt => pt.Payment_details)
                .HasForeignKey(pd => pd.ibp_id)
                .IsRequired();

            // Payment_detail - Payment (One - to - Many)
            modelBuilder.Entity<Payment_detail>()
                .HasOne(pd => pd.Payment)
                .WithMany(pts => pts.Payment_details)
                .HasForeignKey(pd => pd.payment_id)
                .IsRequired();

            // Payment_detail - Status (One - to - Many)
            modelBuilder.Entity<Payment_detail>()
                .HasOne(pd => pd.Status)
                .WithMany(a => a.Payment_details)
                .HasForeignKey(pd => pd.status_id)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // Payment_transaction - Payment (One - to - Many)
            modelBuilder.Entity<Payment_transaction>()
                .HasOne(pt => pt.Payment)
                .WithMany(p => p.Payment_transactions)
                .HasForeignKey(pt => pt.payment_id)
                .IsRequired();

            // Payment_transaction - User (One - to - Many)
            modelBuilder.Entity<Payment_transaction>()
                .HasOne(pt => pt.User)
                .WithMany(b => b.Payment_transactions)
                .HasForeignKey(pt => pt.user_id)
                .IsRequired(false);

            // Payment_transaction - Payment (One - to - Many)
            modelBuilder.Entity<Payment_transaction>()
                .HasOne(pt => pt.Role)
                .WithMany(dp => dp.Payment_transactions)
                .HasForeignKey(pt => pt.Role_id)
                .IsRequired();

            // Payment_transaction - Payment (One - to - Many)
            modelBuilder.Entity<Payment_transaction>()
                .HasOne(pt => pt.Status)
                .WithMany(zp => zp.Payment_transactions)
                .HasForeignKey(pt => pt.status_id)
                .IsRequired();

        //Registration and Adjustment Request
            // Request_transaction - Request (One - to - Many)
            modelBuilder.Entity<Request_transaction>()
                .HasOne(rt => rt.Request)
                .WithMany(r => r.Request_transactions)
                .HasForeignKey(rt => rt.request_id)
                .IsRequired();

            // Request_transaction - User (One - to - Many)
            modelBuilder.Entity<Request_transaction>()
                .HasOne(rt => rt.User)
                .WithMany(rs => rs.Request_transactions)
                .HasForeignKey(rt => rt.user_id)
                .IsRequired(false);

            // Request_transaction - Role (One - to - Many)
            modelBuilder.Entity<Request_transaction>()
                .HasOne(rt => rt.Role)
                .WithMany(rv => rv.Request_transactions)
                .HasForeignKey(rt => rt.role_id)
                .IsRequired();

            // Request_transaction - Status (One - to - Many)
            modelBuilder.Entity<Request_transaction>()
                .HasOne(rt => rt.Status)
                .WithMany(rq => rq.Request_transactions)
                .HasForeignKey(rt => rt.status_id)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
