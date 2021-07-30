select id_patient, tnumber, fio, birthday, subdiv_id, subdiv_name, prof_id, prof_name, initdate, dismisdate 
from subdivision right join (profession right join patient on prof_id=id_prof) on subdiv_id=id_subdiv

select * from ggg left join patient on pat_id=id_patient

SELECT pat_id, measdate, meslist_id, count(*) 
FROM ggg
GROUP BY pat_id, measdate, meslist_id
HAVING count(*) > 1

select p.id_patient, p.prof from patient_old as p group by p.prof

select ggg2.hg, ggg.nameee from ggg2 left join ggg on ggg2.hg = ggg.iu group by hg order by nameee

SELECT v1.pat_id, v1.id_vaccin, v1.vaccine_date, v2.vac_name, v1.dose, v1.series, v1.vac_name_id FROM vaccination v1 INNER JOIN vac_name v2 ON v1.vac_name_id = v2.id_vac_name 
WHERE v1.pat_id = 18

select m.id_meas, m.pat_id, m.meas_date, ml.mestype_id, mt.mestype_name, m.meslist_id, ml.meslist_name 
from measure_list as ml inner join measure_type as mt on mt.id_mestype=ml.mestype_id 
inner join measure as m on m.meslist_id = ml.id_meslist

select e.id_exam, e.exam_date, m.medin_name, e.medin_id from examination e inner join medinst m on e.medin_id = m.id_medin where e.pat_id = 2

SELECT id_mass, mass_date FROM massage WHERE pat_id = 0

SELECT r1.id_roet, r1.roet_date, r2.roet_name, r1.roet_name_id FROM roetgen r1 INNER JOIN roet_name r2 ON r1.roet_name_id = r2.id_roet_name WHERE r1.pat_id = 2

SELECT fio, birthday, place_name, street_name, house, hull, apartment, vaccine_date, vac_name, series 
FROM patient pt INNER JOIN place pl ON pt.place_id = pl.id_place
INNER JOIN street st ON pt.street_id = st.id_street 
INNER JOIN vaccination v1 ON pt.id_patient = v1.pat_id
INNER JOIN vac_name v2 ON v1.vac_name_id = v2.id_vac_name
ORDER BY fio