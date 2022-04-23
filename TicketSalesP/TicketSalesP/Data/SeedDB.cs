namespace TicketSalesP.Data.Entities
{
    public class SeedDB
    {

        private readonly DataContext _context;

        public SeedDB(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckEntrancesAsync();
            await CheckTicketsAsync();
        }

        private async Task CheckEntrancesAsync()
        {
            if (!_context.Entrances.Any())

            {
                //for (int i = 0; i < 5000; i++)
                _context.Entrances.Add(new Entrance
                {
                    Description = "Norte",
                    //for (int i = 0; i < 5000; i++)
                    Tickets = new List<Ticket>()
                        {
                            new Ticket () {WasUsed = true,Document = "123456", name = ""},
                            new Ticket () {WasUsed = true,Document = "", name = ""},
                            new Ticket () {WasUsed = true,Document = "", name = ""},
                            new Ticket () {WasUsed = true,Document = "", name = ""},
                        }
                });

                _context.Entrances.Add(new Entrance
                {
                    Description = "Sur",
                    Tickets = new List<Ticket>()
                {
                    new Ticket() { WasUsed = true,Document = "", name = ""},

                    new Ticket() { WasUsed = true,Document = "", name = ""},
                    new Ticket() { WasUsed = true,Document = "", name = ""},
                    new Ticket() { WasUsed = true,Document = "", name = ""},

                }
                });

                _context.Entrances.Add(new Entrance
                {
                    Description = "Oriental",
                    Tickets = new List<Ticket>() {
                    new Ticket() { WasUsed = true, Document = "", name = "" },
                    new Ticket() { WasUsed = true, Document = "", name = "" },
                    new Ticket() { WasUsed = true, Document = "", name = "" },
                    new Ticket() { WasUsed = true, Document = "", name = "" },

                }
                });

                _context.Entrances.Add(new Entrance
                {
                    Description = "Occidental",
                    Tickets = new List<Ticket>() {
                    new Ticket() { WasUsed = true, Document = "", name = "" },
                    new Ticket() { WasUsed = true, Document = "", name = "" },
                    new Ticket() { WasUsed = true, Document = "", name = "" },
                    new Ticket() { WasUsed = true, Document = "", name = "" },

                }
                });

                await _context.SaveChangesAsync();

            }


        }

        private async Task CheckTicketsAsync()
        {
            if (!_context.Tickets.Any())

            {
                for (int i = 0; i < 5000; i++)
                {
                    _context.Tickets.Add(new Ticket { WasUsed = false, Document = "", name = "", Entrance = null });

                }
            }
        }
    }
}







