INSERT INTO participant (name, surname) VALUES('John', 'Doe'), ('Max', 'Mustermann'), ('Alexandra', 'Rhein');
INSERT INTO team (name, participant_id) VALUES ('FC Koeln', 1);
INSERT INTO trainer (age, participant_id) VALUES (36, 2);
INSERT INTO player (speed, active, participant_id) VALUES ('75.4', 1, 1);
INSERT INTO referee (certificate, participant_id) VALUES ('Advanced', 3);
