abstract class NotificationStrategy {
  abstract send(message: string, recipient: string): void;
}

class EmailStrategy implements NotificationStrategy {
  send(message: string, recipient: string): void {
    console.log(`Send email to ${recipient} with message: ${message}`);
  }
}

class SmsStrategy implements NotificationStrategy {
  send(message: string, recipient: string): void {
    console.log(`Send sms to ${recipient} with message: ${message}`);
  }
}

class PushNotificationStrategy implements NotificationStrategy {
  send(message: string, recipient: string): void {
    console.log(`Send push to ${recipient} with message: ${message}`);
  }
}

class ExecutionContext {
  private strategy: NotificationStrategy;

  constructor(strategy: NotificationStrategy) {
    this.strategy = strategy;
  }

  setStrategy(strategy: NotificationStrategy) {
    this.strategy = strategy;
  }

  execute(message: string, recipient: string) {
    this.strategy.send(message, recipient);
  }
}

const emailStrategy = new EmailStrategy();
const smsStrategy = new SmsStrategy();
const pushStrategy = new PushNotificationStrategy();

const executionContext = new ExecutionContext(smsStrategy);
executionContext.execute("Hello world!", "Krystian");

executionContext.setStrategy(emailStrategy);
executionContext.execute("Hello world!", "Krystian");
