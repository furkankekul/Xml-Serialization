using Microsoft.AspNetCore.Mvc;
using UBLTR.Invoice;
using XML.UblTR;

namespace Invoiceapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {

        [HttpPost("SendDocument")]
        public ActionResult SendDocument([FromBody] string xmlString)
        {
            InvoiceType ublDocument = UBLHelper<InvoiceType>.GetUblTrFromString(xmlString);
            return Ok();
        }

    }
}
