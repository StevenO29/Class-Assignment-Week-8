use premier_league;

select t.team_name as `Team Name`, m.manager_name as `Manager Name`, m.birthdate as `Birthday`, n.nation as `Nationality` 
from manager m, team t, nationality n 
where m.manager_id = t.manager_id and m.nationality_id = n.nationality_id;

select p.player_name as `Player Name`, t.team_name as `Team Name`, p.playing_pos as `Position`, p.height as `Height`, p.weight as `Weight` 
from player p, team t, nationality n 
where p.team_id = t.team_id;

select * from player;

select t.team_name as `Team Home`, t1.team_name as `Team Away`, m.match_date as `Match Date`, m.goal_home as `Goal Home`, 
	   m.goal_away as `Goal Away`, r.referee_name as `Referee Name` 
from `match` m, team t, referee r, team t1 
where m.referee_id = r.referee_id and m.team_home = t.team_id and m.team_away = t1.team_id and (t.team_name = "Chelsea" or t1.team_name = "Chelsea");