using HistoryPediaV2.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HistoryPediaV2.Data.Configuration;

public class ArticlesConfiguration : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.HasData(
            new Article("Roman Empire",
                "Empire of ancient Romans",
                "The Roman Empire (Latin: Imperium Romanum [ɪmˈpɛri.ũː roːˈmaːnũː]; Koinē Greek: Βασιλεία τῶν Ῥωμαίων, romanized: Basileía tōn Rhōmaíōn) was the post-Republican period of ancient Rome. As a polity it included large territorial holdings around the Mediterranean Sea in Europe, Northern Africa, and Western Asia ruled by emperors. From the accession of Caesar Augustus to the military anarchy of the third century, it was a principate with Italy as metropole of the provinces and the city of Rome as sole capital (27 BC – 286 AD). After the military crisis, the empire was ruled by multiple emperors who shared rule over the Western Roman Empire (based in Milan and later in Ravenna) and over the Eastern Roman Empire (also known as the Byzantine Empire; centred on Nicomedia and Antioch, later based in Constantinople). Rome remained the nominal capital of both parts until 476 AD, when the imperial insignia were sent to Constantinople, following the capture of Ravenna by the barbarians of Odoacer and the subsequent deposition of Romulus Augustulus. The fall of the Western Roman Empire to Germanic kings, along with the hellenization of the Eastern Roman Empire into the Byzantine Empire, conventionally marks the end of Ancient Rome and the beginning of the Middle Ages.",
                "RomanEmpIco"),
            new Article("Roman Republic",
                "Republic of ancient Romans",
                "The Roman Republic (Latin: Rēs pūblica Rōmāna [ˈreːs ˈpuːblɪka roːˈmaːna]) was the era of classical Roman civilization, led by the Roman people, beginning with the overthrow of the Roman Kingdom, traditionally dated to 509 BC, and ending in 27 BC with the establishment of the Roman Empire. During this period, Rome's control expanded from the city's immediate surroundings to hegemony over the entire Mediterranean world.",
                "RepublicIco"),
            new Article("Byzantine Empire",
                "Eastern part of Roman Empire",
                "The Byzantine Empire, also referred to as the Eastern Roman Empire, or Byzantium, was the continuation of the Roman Empire in its eastern provinces during Late Antiquity and the Middle Ages, when its capital city was Constantinople (modern Istanbul, formerly Byzantium). It survived the fragmentation and fall of the Western Roman Empire in the 5th century AD and continued to exist for an additional thousand years until it fell to the Ottoman Empire in 1453.[1] During most of its existence, the empire was the most powerful economic, cultural, and military force in Europe. Byzantine Empire is a term created after the end of the realm; its citizens continued to refer to their empire simply as the Roman Empire (Greek: Βασιλεία Ῥωμαίων, tr. Basileía Rhōmaíōn; Latin: Imperium Romanum), or Romania (Greek: Ῥωμανία, romanized: Rhōmanía), and to themselves as Romans (Greek: Ῥωμαῖοι, romanized: Rhōmaîoi). Several signal events from the 4th to 6th centuries mark the period of transition during which the Roman Empire's Greek East and Latin West diverged. Constantine I (r. 324–337) reorganised the empire, made Constantinople the new capital and legalised Christianity. Under Theodosius I (r. 379–395), Christianity became the state religion and other religious practices were proscribed. In the reign of Heraclius (r. 610–641), the Empire's military and administration were restructured and adopted Greek for official use in place of Latin.",
                "ByzantIco"),
            new Article("Ancient Carthage",
                "Ancient Phoenician city-state",
                "Carthage (/ˈkɑːrθədʒ/; Punic: 𐤒𐤓𐤕𐤟𐤇𐤃𐤔𐤕, romanized: Qart-ḥadašt, lit. 'New City'; Latin: Carthāgō) was an ancient Phoenician city-state and civilization located in present-day Tunisia. Founded around 814 BC as a colony of Tyre, within centuries it became the center of the Carthaginian Empire, a major commercial and maritime power that dominated the western Mediterranean until the mid third century BC.",
                "CarthageIco"),
            new Article("Punic wars",
                "Series of wars between Rome and Carthage",
                "The Punic Wars were a series of three wars between 264 and 146 BC fought by the states of Rome and Carthage. The First Punic War broke out in Sicily in 264 BC as a result of Rome's expansionary attitude combined with Carthage's proprietary approach to the island. At the start of the war Carthage was the dominant power of the western Mediterranean, with an extensive maritime empire; while Rome was a rapidly expanding power in Italy, with a strong army but a weak navy. The fighting took place primarily on the Mediterranean island of Sicily and its surrounding waters, and also in North Africa, Corsica and Sardinia. It lasted 23 years, until 241 BC, when after immense materiel and human losses on both sides the Carthaginians were defeated. By the terms of the peace treaty Carthage paid large reparations and Sicily was annexed as a Roman province. The end of the war sparked a major but unsuccessful revolt within the Carthaginian Empire known as the Mercenary War.",
                "PunicIco"),
            new Article("Roman military",
                "Army of ancient Romans",
                "The structural history of the Roman military concerns the major transformations in the organization and constitution of ancient Rome's armed forces, 'the most effective and long - lived military institution known to history.' From its origins around 800 BC to its final dissolution in AD 476 with the demise of the Western Roman Empire, Rome's military organization underwent substantial structural change. At the highest level of structure, the forces were split into the Roman army and the Roman navy, although these two branches were less distinct than in many modern national defense forces. Within the top levels of both army and navy, structural changes occurred as a result of both positive military reform and organic structural evolution. These changes can be divided into four distinct phases.",
                "ArmyIco")
        );
    }
}