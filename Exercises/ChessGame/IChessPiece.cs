namespace ChessGame
{
    public interface IChessPiece
    {
        string Location { get; set; }
        string Color { get; set; }
        public void Move();
    }
}