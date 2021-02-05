
-- WORKY
SELECT Children.FirstName as ChildFirstName, Children.LastName as ChildLastName, in_out, Guardians.FirstName as GuardianFirstName, Guardians.LastName as GuardianLastName, timestamp FROM Attendence INNER JOIN Children on Attendence.child_id = Children.id INNER JOIN Guardians on Attendence.guardian_id = Guardians.id WHERE Attendence.id = (SELECT min(Attendence.id) FROM Attendence WHERE child_id = 3 AND in_out = 'in' AND timestamp LIKE '2021-02-03%');

-- NO WORKY, you need to remove '' around the parameters.
SELECT Children.FirstName as ChildFirstName, Children.LastName as ChildLastName, in_out, Guardians.FirstName as GuardianFirstName, Guardians.LastName as GuardianLastName, timestamp FROM Attendence INNER JOIN Children on Attendence.child_id = Children.id INNER JOIN Guardians on Attendence.guardian_id = Guardians.id WHERE Attendence.id = (SELECT min(Attendence.id) FROM Attendence WHERE child_id = @_child_id AND in_out = '@_in_out' AND timestamp LIKE '@_timestamp');
