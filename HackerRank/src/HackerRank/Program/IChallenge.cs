namespace HackerRank.Program
{
    /// <summary>
    /// Interface that represents a HackerRank challenge.
    /// <remarks>The challenge must have an Input, an Output and Instructions.</remarks>
    /// </summary>
    public interface IChallenge
    {
        /// <summary>
        /// The solution of the hackerRank challenge.
        /// </summary>
        /// <returns>A string representing the output of this challenge.</returns>
        string Output();

        /// <summary>
        /// The input values of the HackerRank challenge.
        /// </summary>
        void Input();

        /// <summary>
        /// The instructions of this HackerRank challenge.
        /// </summary>
        /// <returns>A string representing the instructions of this challenge.</returns>
        string Instructions();
    }
}
