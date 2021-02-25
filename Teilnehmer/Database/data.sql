
INSERT INTO participant (name) VALUES('John'), ('Max'), ('Alexandra'), ('Monika'), ('Jan');
INSERT INTO participant (name) VALUES('Udo'), ('Eva'), ('Klara'), ('Anna'),('Philipp');
INSERT INTO participant (name) VALUES('Udo'), ('Egon'), ('Christian'), ('Torsten'),('Erik'), ('Martin');
INSERT INTO participant (name) VALUES ('FC Koeln'), ('FC Bayern Munich'), ('Borussia Dortmund'), ('FC Schalke 04'), ('RB Leipzig');
INSERT INTO participant (name) VALUES ('Arminia Bielefeld'), ('VFL Rheinbach'), ('Borussia Dortmund');
INSERT INTO team (participant_id) VALUES (17), (18), (19), (20), (21), (24), (22), (23);
INSERT INTO trainer (age, participant_id, team_id, surname) VALUES (36, 2, 1, 'Doe'), (45, 4, 2, 'Halo'), (45, 5, 3, 'Schmidt'), (45, 6, 4, 'Stamm'), (45, 7, 5, 'Dunkel');
INSERT INTO player (speed, active, participant_id, team_id, surname) VALUES ('75.4', 1, 1, 1, 'Heine'), ('75.0', 1, 13, 3, 'Schmidt'), ('85.0', 0, 12, 2, 'Mustermann'), ('80.0', 1, 14, 3, 'Rhein'), ('68.3', 1, 15, 5, 'Elbe'), ('40.0', 0, 16, 5, 'Oder');
INSERT INTO referee (certificate, participant_id, surname) VALUES ('Advanced', 3, 'Donnelly'), ('Assistant', 11, 'Klar'), ('Regional', 8, 'Dell'), ('Advanced', 9, 'Thomas'), ('National', 10, 'Tschüss');
