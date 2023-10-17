using HistoryPediaV2.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HistoryPediaV2.Data.Configuration;

public class PicturesConfiguration : IEntityTypeConfiguration<Picture>
{
    public void Configure(EntityTypeBuilder<Picture> builder)
    {
        builder.HasData(
            new Picture("RomanEmpIco",
                "/Images/RomanEmpIco.png"),
            new Picture("RomanEmp1",
                "/Images/RomanEmp1.png",
                "Map of the Roman Empire"),
            new Picture("RomanEmp2",
                "/Images/RomanEmp2.jpg",
                "The first Roman emperor Octavian Augustus"),
            new Picture("ByzantIco",
                "/Images/ByzantIco.png"),
            new Picture("Byzant1",
                "/Images/Byzant1.jpg",
                "Map of the Byzantine Empire"),
            new Picture("Byzant2",
                "/Images/Byzant2.jpg",
                "Byzantine money"),
            new Picture("RepublicIco",
                "/Images/RepublicIco.png"),
            new Picture("Republic1",
                "/Images/Republic1.jpg",
                "Senate of the republic"),
            new Picture("Republic2",
                "/Images/Republic2.jpg",
                "Survived temple in Rome"),
            new Picture("CarthageIco",
                "/Images/CarthageIco.png"),
            new Picture("Carthage1",
                "/Images/Carthage1.jpg",
                "View on ancient carthage"),
            new Picture("Carthage2",
                "/Images/Carthage2.jpg",
                "Carthage's most popular leader Hannibal Barka"),
            new Picture("PunicIco",
                "/Images/PunicIco.jpg"),
            new Picture("Punic1",
                "/Images/Punic1.jpg",
                "Sea battle of the first punic war"),
            new Picture("Punic2",
                "/Images/Punic2.jpg",
                "Battle of the Cannaes"),
            new Picture("Punic3",
                "/Images/Punic3.jpg",
                "Assault of Carthage"),
            new Picture("ArmyIco",
                "/Images/ArmyIco.jpg"),
            new Picture("Army1",
                "/Images/Army1.jpg",
                "Early roman units"),
            new Picture("Army2",
                "/Images/Army2.jpg",
                "Caesar's legion"),
            new Picture("Army3",
                "/Images/Army3.jpg",
                "Legionaries of Roman Empire"),
            new Picture("Army4",
                "/Images/Army4.jpg",
                "Late roman soldiers"),
            new Picture("DefIco",
                "/Images/DefIco.png"),
            new Picture("Def1",
                "/Images/Def1.jpg",
                "What a picture!")
        );
    }
}