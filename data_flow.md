```mermaid
graph TD
    subgraph "External Systems"
        ZUORA[Zuora API]
        PAYMENT[Payment Systems]
        TAX[Tax Services]
        CRM[CRM Systems]
    end

    subgraph "Zuora Accelerator V2"
        API[API Layer]
        AUTH[Authentication]
        VAL[Validation]
        
        subgraph "Core Services"
            ORDER[Order Service]
            SUB[Subscription Service]
            BILL[Billing Service]
            ACC[Account Service]
        end
        
        subgraph "Data Management"
            DB[(Database)]
            CACHE[(Cache)]
            LOG[Logging]
        end
    end

    %% External System Connections
    ZUORA <--> API
    PAYMENT <--> BILL
    TAX <--> BILL
    CRM <--> ACC

    %% Internal Flow
    API --> AUTH
    AUTH --> VAL
    VAL --> Core Services

    %% Service Connections
    ORDER --> SUB
    SUB --> BILL
    ACC --> ORDER
    ACC --> SUB

    %% Data Management
    Core Services --> DB
    Core Services --> CACHE
    Core Services --> LOG

    %% Legend
    classDef external fill:#f9f,stroke:#333,stroke-width:2px
    classDef service fill:#bbf,stroke:#333,stroke-width:2px
    classDef data fill:#bfb,stroke:#333,stroke-width:2px
    
    class ZUORA,PAYMENT,TAX,CRM external
    class ORDER,SUB,BILL,ACC service
    class DB,CACHE,LOG data
```

# Zuora Accelerator V2 - Data Flow Diagram

## Legend
- **External Systems**: Systems that interact with Zuora Accelerator V2
- **Core Services**: Main business logic components
- **Data Management**: Data storage and logging components

## Flow Description

1. **External Integration**
   - Zuora API: Main integration point for subscription and billing operations
   - Payment Systems: Handles payment processing
   - Tax Services: Manages tax calculations
   - CRM Systems: Provides customer data

2. **API Layer**
   - Entry point for all external requests
   - Handles request routing and response formatting
   - Manages API versioning

3. **Authentication & Validation**
   - Authenticates all incoming requests
   - Validates request data
   - Manages security tokens

4. **Core Services**
   - Order Service: Manages order creation and processing
   - Subscription Service: Handles subscription lifecycle
   - Billing Service: Manages billing and invoicing
   - Account Service: Handles customer account management

5. **Data Management**
   - Database: Stores application data
   - Cache: Improves performance
   - Logging: Tracks system activities

## Data Flow Patterns

1. **Order Processing**
   - CRM → Account Service → Order Service → Subscription Service → Billing Service

2. **Subscription Management**
   - Zuora API → Subscription Service → Billing Service

3. **Billing Operations**
   - Billing Service → Payment Systems
   - Billing Service → Tax Services

4. **Account Management**
   - CRM → Account Service → Order/Subscription Services 