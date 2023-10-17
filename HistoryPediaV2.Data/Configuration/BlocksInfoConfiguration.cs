﻿using HistoryPediaV2.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HistoryPediaV2.Data.Configuration;

public class BlocksInfoConfiguration : IEntityTypeConfiguration<BlockInfo>
{
    public void Configure(EntityTypeBuilder<BlockInfo> builder)
    {
        builder.HasData(
            new BlockInfo("History",
                "The history of the Roman Empire covers the history of ancient Rome from the fall of the Roman Republic in 27 BC until the abdication of Romulus Augustulus in AD 476 in the West, and the Fall of Constantinople in the East in AD 1453. Ancient Rome became a territorial empire while still a republic, but was then ruled by Roman emperors beginning with Augustus (r. 27 BC – 14 AD), becoming the Roman Empire following the death of the last republican dictator, the first emperor's adoptive father Julius Caesar.",
                "RomanEmp1",
                "Roman Empire"),
            new BlockInfo("Emperor",
                "The Latin word imperator derives from the stem of the verb imperare, meaning 'to order, to command'. It was originally employed as a title roughly equivalent to commander under the Roman Republic. Later it became a part of the titulature of the Roman Emperors as part of their cognomen. The English word emperor derives from imperator via Old French: Empereür. The Roman emperors themselves generally based their authority on multiple titles and positions, rather than preferring any single title. Nevertheless, imperator was used relatively consistently as an element of a Roman ruler's title throughout the principate and the dominate.",
                "RomanEmp2",
                "Roman Empire"),
            new BlockInfo("History",
                "Unlike the Pax Romana of the Roman Empire, the Republic was in a state of quasi-perpetual war throughout its existence. Its first enemies were its Latin and Etruscan neighbours as well as the Gauls, who even sacked the city in 387 BC. The Republic nonetheless demonstrated extreme resilience and always managed to overcome its losses, however catastrophic. After the Gallic Sack, Rome conquered the whole Italian peninsula in a century, which turned the Republic into a major power in the Mediterranean. The Republic's greatest enemy was doubtless Carthage, against which it waged three wars. The Punic general Hannibal famously invaded Italy by crossing the Alps and inflicted on Rome two devastating defeats at Lake Trasimene and Cannae, but the Republic once again recovered and won the war thanks to Scipio Africanus at the Battle of Zama in 202 BC. With Carthage defeated, Rome became the dominant power of the ancient Mediterranean world. It then embarked on a long series of difficult conquests, after having notably defeated Philip V and Perseus of Macedon, Antiochus III of the Seleucid Empire, the Lusitanian Viriathus, the Numidian Jugurtha, the Pontic king Mithridates VI, the Gaul Vercingetorix, and the Egyptian queen Cleopatra.",
                "Republic1",
                "Roman Republic"),
            new BlockInfo("Religion",
                "Religion in ancient Rome includes the ancestral ethnic religion of the city of Rome that the Romans used to define themselves as a people, as well as the religious practices of peoples brought under Roman rule, in so far as they became widely followed in Rome and Italy. The Romans thought of themselves as highly religious, and attributed their success as a world power to their collective piety (pietas) in maintaining good relations with the gods. The Romans are known for the great number of deities they honored, a capacity that earned the mockery of early Christian polemicists.",
                "Republic2",
                "Roman Republic"),
            new BlockInfo("History",
                "This history of the Byzantine Empire covers the history of the Eastern Roman Empire from late antiquity until the Fall of Constantinople in 1453 AD. Several events from the 4th to 6th centuries mark the transitional period during which the Roman Empire's east and west divided. In 285, the emperor Diocletian (r. 284–305) partitioned the Roman Empire's administration into eastern and western halves.[1] Between 324 and 330, Constantine I (r. 306–337) transferred the main capital from Rome to Byzantium, later known as Constantinople (City of Constantine) and Nova Roma (New Rome). Under Theodosius I (r. 379–395), Christianity became the Empire's official state religion and others such as Roman polytheism were proscribed. And finally, under the reign of Heraclius (r. 610–641), the Empire's military and administration were restructured and adopted Greek for official use instead of Latin. Thus, although it continued the Roman state and maintained Roman state traditions, modern historians distinguish Byzantium from ancient Rome insofar as it was oriented towards Greek rather than Latin culture, and characterised by Orthodox Christianity rather than Roman polytheism.",
                "Byzant1",
                "Byzantine Empire"),
            new BlockInfo("Economy",
                "The Byzantine economy was among the most robust economies in the Mediterranean for many centuries. Constantinople was a prime hub in a trading network that at various times extended across nearly all of Eurasia and North Africa. Some scholars argue that, up until the arrival of the Arabs in the 7th century, the Eastern Roman Empire had the most powerful economy in the world. The Arab conquests, however, would represent a substantial reversal of fortunes contributing to a period of decline and stagnation. Constantine V's reforms (c. 765) marked the beginning of a revival that continued until 1204. From the 10th century until the end of the 12th, the Byzantine Empire projected an image of luxury, and the travelers were impressed by the wealth accumulated in the capital. All this changed with the arrival of the Fourth Crusade, which was an economic catastrophe. The Palaiologoi tried to revive the economy, but the late Byzantine state would not gain full control of either the foreign or domestic economic forces.",
                "Byzant2",
                "Byzantine Empire"),
            new BlockInfo("History",
                "The city of Carthage was founded in the 9th century BC on the coast of Northwest Africa, in what is now Tunisia, as one of a number of Phoenician settlements in the western Mediterranean created to facilitate trade from the city of Tyre on the coast of what is now Lebanon. The name of both the city and the wider republic that grew out of it, Carthage developed into a significant trading empire throughout the Mediterranean. The date from which Carthage can be counted as an independent power cannot exactly be determined, and probably nothing distinguished Carthage from the other Phoenician colonies in Northwest Africa and the Mediterranean during 800–700 BC. By the end of the 7th century BC, Carthage was becoming one of the leading commercial centres of the West Mediterranean region. After a long conflict with the emerging Roman Republic, known as the Punic Wars (264–146 BC), Rome finally destroyed Carthage in 146 BC. A Roman Carthage was established on the ruins of the first. Roman Carthage was eventually destroyed—its walls torn down, its water supply cut off, and its harbours made unusable—following its conquest by Arab invaders at the close of the 7th century. It was replaced by Tunis as the major regional centre, which has spread to include the ancient site of Carthage in a modern suburb.",
                "Carthage1",
                "Ancient Carthage"),
            new BlockInfo("Government and politics",
                "Like most ancient societies, including the Phoenician city-states, Carthage was initially ruled as a monarchy, although modern scholars debate whether this stemmed from a misunderstanding by Greek writers. Traditionally, most Phoenician kings did not exercise absolute power, but consulted with a body of advisors called the Adirim (mighty ones), which was likely comprised of the wealthiest members of society, namely merchants.[121] Carthage seems to have been ruled by a similar body known as the Blm, made up of nobles responsible for all important matters of state, including religion, administration, and the military.[120] Within this cabal was a hierarchy topped by the dominant family, usually the wealthiest members of the merchant class, which had some sort of executive power. Records indicate that different families held power at different times, suggesting a nonhereditary system of government dependent on the support or approval of the consultative body.",
                "Carthage2",
                "Ancient Carthage"),
            new BlockInfo("First Punic War, 264–241 BC",
                "The First Punic War (264–241 BC) was the first of three wars fought between Carthage and Rome, the two main powers of the western Mediterranean in the early 3rd century BC. For 23 years, in the longest continuous conflict and greatest naval war of antiquity, the two powers struggled for supremacy. The wars were fought primarily on the Mediterranean island of Sicily and its surrounding waters, and also in North Africa. After immense material and human losses on both sides the Carthaginians were defeated.",
                "Punic1",
                "Punic wars"),
            new BlockInfo("Second Punic War, 218–201 BC",
                "The Second Punic War (218–201 BC) was the second of three wars fought between Carthage and Rome, the two main powers of the western Mediterranean in the 3rd century BC. For 17 years the two states struggled for supremacy, primarily in Italy and Iberia, but also on the islands of Sicily and Sardinia and, towards the end of the war, in North Africa. After immense material and human losses on both sides the Carthaginians were defeated. Macedonia, Syracuse and several Numidian kingdoms were drawn into the fighting; and Iberian and Gallic forces fought on both sides. There were three main military theatres during the war: Italy, where the Carthaginian general Hannibal defeated the Roman legions repeatedly, with occasional subsidiary campaigns in Sicily, Sardinia and Greece; Iberia, where Hasdrubal, a younger brother of Hannibal, defended the Carthaginian colonial cities with mixed success until moving into Italy; and Africa, where the war was decided.",
                "Punic2",
                "Punic wars"),
            new BlockInfo("Third Punic War, 149–146 BC",
                "The Third Punic War was the third and last of the Punic Wars fought between Carthage and Rome, and lasted from 149 to 146 BC. The war was fought entirely within Carthaginian territory, in modern northern Tunisia. When the Second Punic War ended in 201 BC, one of the terms of the peace treaty prohibited Carthage from waging war without Rome's permission. Rome's ally, King Masinissa of Numidia, exploited this to repeatedly raid and seize Carthaginian territory with impunity. In 149 BC Carthage sent an army, under Hasdrubal, against Masinissa, the treaty notwithstanding. The campaign ended in disaster as the Battle of Oroscopa ended with a Carthaginian defeat and the surrender of the Carthaginian army. Anti-Carthaginian factions in Rome used the illicit military action as a pretext to prepare a punitive expedition.",
                "Punic3",
                "Punic wars"),
            new BlockInfo("Phase I",
                "The army was derived from obligatory annual military service levied on the citizenry, as part of their duty to the state. During this period, the Roman army would wage seasonal campaigns against largely local adversaries.",
                "Army1",
                "Roman military"),
            new BlockInfo("Phase II",
                "As the extent of the territories falling under Roman control expanded and the size of the forces increased, the soldiery gradually became salaried professionals. As a consequence, military service at the lower (non-salaried) levels became progressively longer-term. Roman military units of the period were largely homogeneous and highly regulated. The army consisted of units of citizen infantry known as legions (Latin: legiones) as well as non-legionary allied troops known as auxilia. The latter were most commonly called upon to provide light infantry, logistical, or cavalry support.",
                "Army2",
                "Roman military"),
            new BlockInfo("Phase III",
                "At the height of the Roman Empire's power, forces were tasked with manning and securing the borders of the vast provinces which had been brought under Roman control. Serious strategic threats were less common in this period and emphasis was placed on preserving gained territory. The army underwent changes in response to these new needs and became more dependent on fixed garrisons than on march-camps and continuous field operations.",
                "Army3",
                "Roman military"),
            new BlockInfo("Phase IV",
                "As Rome began to struggle to keep control over its sprawling territories, military service continued to be salaried and professional for Rome's regular troops. However, the trend of employing allied or mercenary elements was expanded to such an extent that these troops came to represent a substantial proportion of the armed forces. At the same time, the uniformity of structure found in Rome's earlier military disappeared. Soldiery of the era ranged from lightly armed mounted archers to heavy infantry, in regiments of varying size and quality. This was accompanied by a trend in the late empire of an increasing predominance of cavalry rather than infantry troops, as well as a requirement for more mobile operations. In this period there was more focus (on all frontiers but the east) on smaller units of independently-operating troops, engaging less in set-piece battles and more in low-intensity, guerilla actions.",
                "Army4",
                "Roman military")
        );
    }
}