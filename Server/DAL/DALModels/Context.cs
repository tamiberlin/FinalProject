﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.DALModels;

public partial class Context : DbContext
{
    public Context()
    {
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AtractionsToTour> AtractionsToTours { get; set; }

    public virtual DbSet<Attraction> Attractions { get; set; }

    public virtual DbSet<Costumer> Costumers { get; set; }

    public virtual DbSet<DatesForRoom> DatesForRooms { get; set; }

    public virtual DbSet<Destination> Destinations { get; set; }

    public virtual DbSet<Flight> Flights { get; set; }

    public virtual DbSet<Housing> Housings { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Tour> Tours { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"H:\\פולסטאק-פרויקט כולל\\FinalProject\\DB\\Database.mdf\";Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AtractionsToTour>(entity =>
        {
            entity.HasKey(e => e.Attid).HasName("PK__Atractio__32EB7E9F81A1F213");

            entity.Property(e => e.Attid).HasColumnName("ATTID");

            entity.HasOne(d => d.AttractionCodeNavigation).WithMany(p => p.AtractionsToTours)
                .HasForeignKey(d => d.AttractionCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Atraction__Attra__22751F6C");

            entity.HasOne(d => d.TourCodeNavigation).WithMany(p => p.AtractionsToTours)
                .HasForeignKey(d => d.TourCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Atraction__TourC__236943A5");
        });

        modelBuilder.Entity<Attraction>(entity =>
        {
            entity.HasKey(e => e.AttractionId).HasName("PK__tmp_ms_x__DAE24DBAF27AF98F");

            entity.Property(e => e.AttractionId).HasColumnName("AttractionID");
            entity.Property(e => e.AttractionName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PricePerTicket).HasColumnType("money");

            entity.HasOne(d => d.AddressCodeNavigation).WithMany(p => p.Attractions)
                .HasForeignKey(d => d.AddressCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Attractio__Addre__17F790F9");
        });

        modelBuilder.Entity<Costumer>(entity =>
        {
            entity.HasKey(e => e.CostumerId).HasName("PK__Costumer__8E5D6990C283A630");

            entity.Property(e => e.CostumerId)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("CostumerID");
            entity.Property(e => e.CostumerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.PaymentCodeNavigation).WithMany(p => p.Costumers)
                .HasForeignKey(d => d.PaymentCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Costumers__Payme__19DFD96B");

            entity.HasOne(d => d.TourCodeNavigation).WithMany(p => p.Costumers)
                .HasForeignKey(d => d.TourCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Costumers__TourC__1CBC4616");
        });

        modelBuilder.Entity<DatesForRoom>(entity =>
        {
            entity.HasKey(e => e.DateId).HasName("PK__DatesFor__A426F253F7ACEE3D");

            entity.Property(e => e.DateId).HasColumnName("DateID");
            entity.Property(e => e.CostumerCode)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.StartDate).HasColumnType("date");

            entity.HasOne(d => d.CostumerCodeNavigation).WithMany(p => p.DatesForRooms)
                .HasForeignKey(d => d.CostumerCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DatesForR__Costu__2180FB33");

            entity.HasOne(d => d.RoomCodeNavigation).WithMany(p => p.DatesForRooms)
                .HasForeignKey(d => d.RoomCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DatesForR__RoomC__208CD6FA");
        });

        modelBuilder.Entity<Destination>(entity =>
        {
            entity.HasKey(e => e.DestinationId).HasName("PK__Destinat__DB5FE4AC3965D047");

            entity.Property(e => e.DestinationId).HasColumnName("DestinationID");
            entity.Property(e => e.CityName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.CountryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<Flight>(entity =>
        {
            entity.HasKey(e => e.FlightId).HasName("PK__Flights__8A9E148E58C7D006");

            entity.Property(e => e.FlightId)
                .ValueGeneratedNever()
                .HasColumnName("FlightID");
            entity.Property(e => e.ArrivalTime).HasColumnName("Arrival time");
            entity.Property(e => e.Company)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.LeavingTime).HasColumnName("Leaving time");

            entity.HasOne(d => d.DepartureCodeNavigation).WithMany(p => p.FlightDepartureCodeNavigations)
                .HasForeignKey(d => d.DepartureCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Flights__Departu__14270015");

            entity.HasOne(d => d.DestinationCodeNavigation).WithMany(p => p.FlightDestinationCodeNavigations)
                .HasForeignKey(d => d.DestinationCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Flights__Destina__151B244E");
        });

        modelBuilder.Entity<Housing>(entity =>
        {
            entity.HasKey(e => e.HouseId).HasName("PK__Housing__085D12AFB8E2DA1D");

            entity.ToTable("Housing");

            entity.Property(e => e.HouseId).HasColumnName("HouseID");
            entity.Property(e => e.Cosher)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.HouseName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PricePerBed).HasColumnType("money");

            entity.HasOne(d => d.AddressCodeNavigation).WithMany(p => p.Housings)
                .HasForeignKey(d => d.AddressCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Housing__Address__160F4887");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__tmp_ms_x__9B556A585717AA69");

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.CreditCardNumber)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Cvv).HasColumnName("CVV");
            entity.Property(e => e.OwnerId)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("OwnerID");
            entity.Property(e => e.Validity)
                .HasColumnType("date")
                .HasColumnName("validity");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.RoomId).HasName("PK__tmp_ms_x__328639193771063A");

            entity.Property(e => e.RoomId).HasColumnName("RoomID");

            entity.HasOne(d => d.HouseCodeNavigation).WithMany(p => p.Rooms)
                .HasForeignKey(d => d.HouseCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Rooms__HouseCode__17036CC0");
        });

        modelBuilder.Entity<Tour>(entity =>
        {
            entity.HasKey(e => e.TourCode).HasName("PK__tmp_ms_x__1982F8D1BAB28C7C");

            entity.Property(e => e.TourCode).ValueGeneratedNever();
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.TourName)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.DestinationCodeNavigation).WithMany(p => p.Tours)
                .HasForeignKey(d => d.DestinationCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tours__Destinati__1EA48E88");

            entity.HasOne(d => d.FlightCodeNavigation).WithMany(p => p.Tours)
                .HasForeignKey(d => d.FlightCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tours__FlightCod__1DB06A4F");

            entity.HasOne(d => d.HouseCodeNavigation).WithMany(p => p.Tours)
                .HasForeignKey(d => d.HouseCode)
                .HasConstraintName("FK__Tours__HouseCode__1F98B2C1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
