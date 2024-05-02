CREATE OR REPLACE PROCEDURE GetCategories (Categories OUT SYS_REFCURSOR)
AS
BEGIN
    OPEN Categories FOR
    SELECT DISTINCT(m_category)
    FROM magazines;
END;
