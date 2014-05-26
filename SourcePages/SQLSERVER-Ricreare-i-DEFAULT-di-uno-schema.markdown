
Eseguendo questo script su un database sqlserver vengono mostrate due colonne con gli statement di drop e di create dei default

     SQL
    
    SELECT
      DefCons.name AS ConstraintName,
      schema_name(Tab.schema_id) AS SchemaName,
      OBJECT_NAME(DefCons.parent_object_id) AS TableName,
      Col.name AS ColumnName,
      DefCons.definition AS ConstraintValue,
      'ALTER TABLE [' + schema_name(Tab.schema_id) + '].[' + OBJECT_NAME(DefCons.parent_object_id) +'] ADD CONSTRAINT ['+DefCons.name+'] DEFAULT ' + DefCons.definition + ' FOR [' + Col.name + ']' AS ConstraintScript,
      'ALTER TABLE [' + schema_name(Tab.schema_id) + '].[' + OBJECT_NAME(DefCons.parent_object_id) +'] DROP CONSTRAINT ['+DefCons.name+']' AS dropScript
    FROM
      sys.default_constraints AS DefCons
    INNER JOIN
      sys.columns AS Col
    ON
      DefCons.parent_object_id = Col.object_id AND DefCons.parent_column_id = Col.column_id
    INNER JOIN
      sys.tables Tab
    ON
      Tab.object_id=Col.object_id
    

