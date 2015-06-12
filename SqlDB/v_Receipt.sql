CREATE VIEW [dbo].[v_Receipt]
	AS 
select 
  m.id, m.DeliveryName, m.Amount as mAmount, m.PayRef as mPayRef, m.PayType as mPayType, m.PayVia as mPayVia, m.Note as mnote,
  d.Account as dAccount, d.name as dName, d.Amount as dAmount, d.Note as dnote
from CRMaster m
inner join CRDetail d on m.id = d.CRMid


