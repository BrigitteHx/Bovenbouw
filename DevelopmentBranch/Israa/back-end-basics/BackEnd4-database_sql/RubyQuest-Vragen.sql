-- SELECT *


-- Met welke query haal je alle helden op uit de database?
SELECT * FROM hero;

-- Met welke query haal je alle personen op uit de database?
SELECT * FROM person;

-- Hoeveel personen zijn NPC’s?
SELECT COUNT(person) FROM npc;

-- Met welke query haal je alle opdrachten (taken) op uit de database?
SELECT * FROM quest;

-- Hoeveel dieren zijn er in RubyQuest?
SELECT COUNT(*) FROM animal;

-- Met welke query haal je alle wezens op uit de database?
SELECT * FROM creature;
-- Met welke query laat je alle personen zien gesorteerd op naam (ascending)?
SELECT * FROM person ORDER BY name ASC;

-- Met welke query laat je alle steden zien gesorteerd op naam (descending)?
SELECT * FROM city ORDER BY name DESC;

-- Hoeveel steden zijn er aanwezig?
 SELECT COUNT(*) FROM city;



-- SELECT [column], [column]

-- Met welke query haal je alle namen van bescherming op uit de database?
SELECT name FROM armor;

-- Met welke query haal je alle namen en aanvalskracht van wapens op uit de database?
SELECT name, attack FROM weapon;

-- Met welke query haal je alle namen en gezondheid van alle wezens op uit de database?
SELECT name, health FROM creature;


-- SELECT WHERE

-- Met welke query kan je alleen de schapen laten zien die er in RubyQuest te vinden zijn?
SELECT * FROM animal WHERE type = 'Sheep';

-- Met welke query kan je zien hoeveel schapen er in RubyQuest te vinden zijn?
SELECT COUNT(*) FROM animal WHERE type = 'Sheep';

-- Hoeveel zeeslangen zijn er te vinden in RubyQuest?
SELECT COUNT(*) FROM creature WHERE type = 'Sea Serpent';

-- Welke persoon heeft id 7?
SELECT * FROM person WHERE id = 7;

-- Met welke 2 query’s kan je nagaan of de persoon uit vraag 4 een held of een NPC is?
SELECT * FROM hero WHERE person = 7;
SELECT * FROM npc WHERE person = 7;