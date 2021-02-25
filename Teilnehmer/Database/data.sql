INSERT INTO participant (name, surname) VALUES('John', 'Doe'), ('Max', 'Mustermann'), ('Alexandra', 'Rhein'), ('Monika', 'Oder'), ('Jan', 'Elbe');
INSERT INTO participant (name, surname) VALUES('Udo', 'Heine'), ('Eva', 'Schmidt'), ('Klara', 'Donnelly'), ('Anna', 'Klar'),('Philipp', 'Dell');
INSERT INTO participant (name, surname) VALUES('Udo', 'Halo'), ('Egon', 'Schmidt'), ('Christian', 'Stamm'), ('Torsten', 'Dunkel'),('Erik', 'Tschüss'), ('Martin', 'Thomas');
INSERT INTO team (name) VALUES ('FC Koeln'), ('FC Bayern Munich'), ('Borussia Dortmund'), ('FC Schalke 04'), ('RB Leipzig');
INSERT INTO trainer (age, participant_id, team_id) VALUES (36, 2, 1), (45, 4, 2), (45, 5, 3), (45, 6, 4), (45, 7, 5);
INSERT INTO player (speed, active, participant_id, team_id) VALUES ('75.4', 1, 1, 1), ('75.0', 1, 13, 3), ('85.0', 0, 12, 2), ('80.0', 1, 14, 3), ('68.3', 1, 15, 5), ('40.0', 0, 16, 5);
INSERT INTO referee (certificate, participant_id) VALUES ('Advanced', 3), ('Assistant', 11), ('Regional', 8), ('Advanced', 9), ('National', 10);

/**
TODO: Update according to the new schema!!!
 */