# promoIT
# System Overview

PromoIt is a system to promote social campaigns and drive positive change. By onboarding business organizations, non-profit organizations, and social activists on Twitter, PromoIt facilitates collaboration and amplifies the impact of social initiatives. With a focus on simplicity and leveraging the power of social media, PromoIt empowers users to create a better society through effective promotion and engagement. Join us as we revolutionize social campaigns and make a lasting difference.

## Technologies Used

### Database:
- MS SQL database hosted in Azure Cloud

### Backend:
- Node.js
  - TypeScript
  - sequelize-typescript
  - twitter-api-v2 for twitter API
- .NET
  - C#
  - Entity Framework
- Authentication: Auth0
### Frontend:
- Blazor

## Short Review
The system architecture is based on a combination of technologies that communicate with each other using the HTTP protocol. The application follows a multilayer architecture. Client-side requests (Blazor) are routed to the server-side (Node.js and .NET) based on their type. The business logic layer (controllers) on the server-side handles data management and modification. Services and helpers are employed to make targeted adjustments to the controllers in order to achieve the desired data model. Furthermore, database connection classes constitute an additional layer responsible for performing all data operations, encompassing creation, retrieval, updating, and deletion.

## System Users

The following user roles are involved in the system:

1. **ProLobby Owner:** Represents the company and manages the system.
2. **Non-Profit Organization Representative:** Creates campaigns on behalf of their organization.
3. **Business Company Representative:** Represents a company that donates products for campaigns.
4. **Social Activists:** Twitter users who actively promote campaigns.

## User Stories and their implementation

1. As a non-profit organization representative, I want to register in the system to create a campaign.
   - Provide organization details such as name, email, and website link.

2. As a non-profit organization representative, I want to create a campaign.
   - Specify the campaign landing page URL and a unique campaign hashtag.

3. As a business company representative, I want to register in the system to donate products.
   - Provide necessary information for registration.

4. As a business company representative, I want to donate goods to selected campaigns.
   - Specify the quantity and value (in dollars) of products donated to each campaign.

5. As a business company representative, I want to obtain a list of users and products that need to be shipped.
   - Access the relevant data, including product ID and user details.

6. As a business company representative, I want to notify the system when I have sent a product to a user.
   - Mark the transaction as completed in the system.

7. As a social activist, I want to register in the system to earn money and utilize it to purchase products.
   - Provide personal details such as email, address, and phone number.

8. As a social activist, I want to promote campaigns by tweeting about them to earn money.
   
9. As the ProLobby owner, I want to allocate one dollar to social activists for each tweet promoting a campaign, including subsequent retweets.
   - Tweets must contain the campaign page link and hashtag.

10. As a social activist, I want to use my earned money to buy products.

11. As the ProLobby owner, I want the system to automatically post a tweet whenever a social activist uses their points to purchase a product.
   - The tweet should mention the social activist's Twitter handle and the associated business company.

12. As a social activist, I want to view my earning status to keep track of my balance.

13. As a social activist, I want to donate a product to my chosen campaign to further promote it.
   - By earning money, purchasing a product, and donating it, I can increase the campaign's product inventory.

14. As the ProLobby owner, I want the system to generate reports on the following:
   a. Campaigns
   b. Users
   c. Tweets

## Project Team

This project is performed by the following team members:

- Popkova Ekaterina
  - GitHub: [ekaterinapopkova](https://github.com/ekaterinapopkova)
  - LinkedIn: [ekaterinapopkova](https://www.linkedin.com/in/ekaterinapopkova/)

- Daniel Sizov (Lippo)
  - GitHub: [danielsizov](https://github.com/DanSizov)
  - LinkedIn: [danielsizov](https://www.linkedin.com/in/daniil-sizov/)

Feel free to reach out to us for any inquiries or collaboration opportunities related to this project.

