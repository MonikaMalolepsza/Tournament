CREATE SCHEMA IF NOT EXISTS `tournament` DEFAULT CHARACTER SET utf8;
USE `tournament` ;

CREATE TABLE `tournament`.`participant` (
                                            `name` VARCHAR(50) NULL DEFAULT NULL,
                                            `id` INT(11) NOT NULL AUTO_INCREMENT,
                                            PRIMARY KEY (`id`)
);

CREATE TABLE `tournament`.`team` (
                                     `id` INT(11) NOT NULL AUTO_INCREMENT,
                                     PRIMARY KEY (`id`),
                                     `participant_id` INT(11) NULL DEFAULT NULL,
                                     INDEX `fk_participant` (`participant_id`),
                                     CONSTRAINT `fk_participant` FOREIGN KEY (`participant_id`) REFERENCES `participant` (`id`)
);

CREATE TABLE `tournament`.`referee` (
                                        `id` INT(11) NOT NULL AUTO_INCREMENT,
                                        `surname` VARCHAR(50) NULL DEFAULT NULL,
                                        `certificate` VARCHAR(255) NULL,
                                        PRIMARY KEY (`id`),
                                        `participant_id` INT(11) NULL DEFAULT NULL,
                                        INDEX `fk_referee_participant` (`participant_id`),
                                        CONSTRAINT `fk_referee_participant` FOREIGN KEY (`participant_id`) REFERENCES `participant` (`id`)
);

CREATE TABLE `tournament`.`player` (
                                       `id` INT(11) NOT NULL AUTO_INCREMENT,
                                       `surname` VARCHAR(50) NULL DEFAULT NULL,
                                       `speed` FLOAT NOT NULL,
                                       `active` TINYINT(1) NULL,
                                       PRIMARY KEY (`id`),
                                       `participant_id` INT(11) NULL DEFAULT NULL,
                                       INDEX `fk_player_participant` (`participant_id`),
                                       CONSTRAINT `fk_player_participant` FOREIGN KEY (`participant_id`) REFERENCES `participant` (`id`),
                                       `team_id` INT(11) NULL DEFAULT NULL,
                                       INDEX `fk_player_team` (`team_id`),
                                       CONSTRAINT `fk_player_team` FOREIGN KEY (`team_id`) REFERENCES `team` (`id`)
);

CREATE TABLE `tournament`.`trainer` (
                                        `id` INT(11) NOT NULL AUTO_INCREMENT,
                                        `surname` VARCHAR(50) NULL DEFAULT NULL,
                                        `age` INT(2) NULL,
                                        PRIMARY KEY (`id`),
                                        `participant_id` INT(11) NULL DEFAULT NULL,
                                        INDEX `fk_trainer_participant` (`participant_id`),
                                        CONSTRAINT `fk_trainer_participant` FOREIGN KEY (`participant_id`) REFERENCES `participant` (`id`),
                                        `team_id` INT(11) NULL DEFAULT NULL,
                                        INDEX `fk_trainer_team` (`team_id`),
                                        CONSTRAINT `fk_trainer_team` FOREIGN KEY (`team_id`) REFERENCES `team` (`id`)

);

