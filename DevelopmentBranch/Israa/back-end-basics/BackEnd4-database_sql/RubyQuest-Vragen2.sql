-- DISTINCT

-- Met welke query kun je laten zien welke verschillende dieren er bestaan?
SELECT DISTINCT type FROM animal;

-- Met welke query kun je laten zien welke professions er zijn bij de NPC’s?
SELECT DISTINCT profession FROM npc;
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 

-- AND, OR and NOT

-- Met welke query kun je de creatures laten zien die voldoen aan ‘Killer Bee’ of ‘Orc’?
SELECT * FROM creature 
WHERE name = 'Killer Bee' OR name = 'Orc';

-- Met welke query kun je de dieren laten zien die voldoen aan snelheid 6 en verdediging 5?
SELECT * FROM animal
WHERE speed = 6 AND defense = 5;

-- Met welke query kun je alle dieren laten zien behalve de schapen?
SELECT * FROM animal
WHERE NOT type= 'Sheep';

-- Met welke query kun je het aantal dieren laten zien die voldoen aan ‘Wolf’ of ‘Bear’ of ‘Eagle’
SELECT COUNT(*) FROM animal
WHERE type IN ('Wolf', 'Bear', 'Eagle');


-- Met welke query kun je de personen laten zien waarvoor geldt attack, defense en agility voor alle drie de waarde gelijk aan 10?
SELECT * FROM person
WHERE attack = 10 AND defense = 10 AND agility = 10;


-- Met welke query kun je de steden laten zien die vallen in regio 1 of 2?
SELECT * FROM city
WHERE region IN (1,2)

-- Met welke query kun je alle hero’s laten zien met intelligence anders dan 30 of 90?
SELECT * FROM hero
WHERE intelligence NOT IN (30, 90);
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 

-- MIN and MAX

-- Met welke query kun je zien welke minimale snelheid de dieren hebben?
SELECT MIN(speed)
FROM animal;

-- Met welke query kun je zien wat de snelheid is van het snelste dier?
SELECT MAX(speed)
FROM animal;

-- Met welke query kun je laten zien wat de minimale attack van een wapen is?
SELECT MIN(attack)
FROM weapon;

-- Met welke query kun je laten zien hoeveel het duurste wapen kost?
SELECT MAX(price)
FROM weapon;
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 

-- IN

-- Met welke query kun je de creatures laten zien die voldoen aan ‘Killer Bee’ of ‘Orc’?
SELECT * FROM creature
WHERE name IN ('Killer Bee', '‘Orc’');

-- Met welke query kun je het aantal dieren laten zien gesorteerd op alfabet die voldoen aan ‘Wolf’ of ‘Bear’ of ‘Eagle’
SELECT *FROM animal 
WHERE type IN ('Wolf', 'Bear', 'Eagle')
ORDER BY type;

-- Met welke query kun je alle creatures laten zien behalve de ‘Killer Bee’ en de ‘Orc’?
SELECT * FROM creature 
WHERE name NOT IN ('Killer Bee', 'Orc')

-- Met welke query kun je alle namen van de steden laten zien die vallen in de regio South Groval of Nort Groval?
SELECT name FROM city
WHERE region IN ('South Groval', 'Nort Groval');

-- Met welke query kun je vraag 4 sorteren op alfabet?
SELECT *FROM animal 
WHERE type IN ('Wolf', 'Bear', 'Eagle')
ORDER BY type ASC;

-- Met welke query kun je bepalen hoeveel steden er vallen binnen de region South Groval of Nort Groval?
SELECT COUNT(*) FROM city
WHERE region IN ('South Groval', 'Nort Groval');
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 

-- BETWEEN and SQL operators

-- Met welke query kun je de wapens laten zien met een prijs van 100 – 1000?
SELECT * FROM weapon
WHERE price BETWEEN 100 AND 1000;

-- Met welke query kun je de wapens laten zien met een attack van 300 – 600?
SELECT * FROM weapon
WHERE attack BETWEEN 300 AND 600;

-- Met welke query kun je het aantal dieren zien die een defense hebben van 7 – 9?
SELECT COUNT(*) FROM animal
WHERE defense BETWEEN 7 AND 9;

-- Met welke query kun je de personen laten zien die meer dan 1800 goud hebben?
SELECT * FROM person
WHERE gold > 1800;
-- Met welke query kun je de personen laten zien die meer dan 1850 goud hebben?
SELECT * FROM person
WHERE gold > 1850;

-- Met welke query kun je de personen laten zien die 1850 of meer goud hebben?
SELECT * FROM person
WHERE gold >= 1850;

-- Met welke query kun je de wapens laten zien die minder dan 300 kosten?
SELECT * FROM weapon
WHERE price < 300;
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 

-- LIKE

-- Met welke query kan je alle personen laten zien de beginnen met de letter B?
SELECT * FROM person
WHERE name LIKE 'B%';

-- Met welke query kan je alle dieren laten zien waar de letter a in zit?
SELECT * FROM animal
WHERE type LIKE '%a%';

-- Met welke query kan je alle dieren laten zien waar achter de letter e een letter a in zit?
SELECT * FROM animal
WHERE type LIKE '%e%a%';

-- Met welke query kan je alle wapens laten zien die eindigen op de letter d?
SELECT * FROM weapon 
WHERE name LIKE '%d';
-- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- 

 
-- TOP, LIMIT or ROWNUM

-- Met welke query kun je de eerste 10 personen laten zien?
SELECT * FROM person LIMIT 10;

-- Met welke query kun je de 5 duurste wapens laten zien?
SELECT * FROM weapon
ORDER BY price DESC LIMIT 5;


-- Met welke query kun je de beste 3 wapens laten zien die een attack hebben van 700 – 900?
SELECT TOP 3 * FROM weapon
WHERE attack BETWEEN 700 AND 900;