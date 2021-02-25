SELECT * FROM trainer;
SELECT * FROM trainer WHERE age > 40;
SELECT * FROM player;
SELECT * FROM player WHERE active = true;
SELECT * FROM referee WHERE certificate = 'Advanced';

SELECT name, surname, active
                   FROM participant as p
                            inner JOIN player ON p.id=player.participant_id
                   ORDER BY p.surname

SELECT name, surname, speed, certificate, active, age, p.id
FROM participant as p
    LEFT OUTER JOIN trainer ON p.id=trainer.participant_id
    LEFT OUTER JOIN player ON p.id=player.participant_id
    LEFT OUTER JOIN referee ON p.id=referee.participant_id
ORDER BY p.surname;

SELECT name, surname, speed, certificate, active, age, p.id
FROM participant as p
    LEFT OUTER JOIN trainer ON p.id=trainer.participant_id
    LEFT OUTER JOIN player ON p.id=player.participant_id
    LEFT OUTER JOIN referee ON p.id=referee.participant_id
ORDER BY trainer.age;